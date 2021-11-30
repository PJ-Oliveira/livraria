using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace livraria
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string sqlString;


        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost; Port=8089; Database=livraria; Uid=root;Pwd=12345;");

                sqlString = "INSERT INTO LIVRARIA(TITULO, TEMA, AUTOR) VALUES (@TITULO, @TEMA, @AUTOR)";

                command = new MySqlCommand(sqlString, connection);

                command.Parameters.AddWithValue("@TITULO", txtTitulo.Text);
                command.Parameters.AddWithValue("@TEMA", txtTema.Text);
                command.Parameters.AddWithValue("@Autor", txtAutor.Text);

                connection.Open();

                command.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost; Port=8089; Database=livraria; Uid=root;Pwd=12345;");

                sqlString = "UPDATE LIVRARIA SET TITULO = @TITULO, TEMA = @TEMA, AUTOR = @AUTOR WHERE ID = @ID";

                command = new MySqlCommand(sqlString, connection);
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@TITULO", txtTitulo.Text);
                command.Parameters.AddWithValue("@TEMA", txtTema.Text);
                command.Parameters.AddWithValue("@Autor", txtAutor.Text);

                connection.Open();

                command.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost; Port=8089; Database=livraria; Uid=root;Pwd=12345;");

                sqlString = "DELETE FROM LIVRARIA WHERE ID = @ID";

                command = new MySqlCommand(sqlString, connection);

                command.Parameters.AddWithValue("@ID", txtID.Text);

                connection.Open();

                command.ExecuteNonQuery();
                MessageBox.Show("Deletado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void Exibir_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new MySqlConnection("Server=localhost; Port=8089; Database=livraria; Uid=root;Pwd=12345;");

                sqlString = "SELECT * FROM LIVRARIA";

                adapter = new MySqlDataAdapter(sqlString, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

           

        }

        private void Consulta_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new MySqlConnection("Server=localhost; Port=8089; Database=livraria; Uid=root;Pwd=12345;");

                sqlString = "SELECT * FROM LIVRARIA WHERE ID = @ID";

                command = new MySqlCommand(sqlString, connection);

                command.Parameters.AddWithValue("@ID", txtID.Text);
                

                connection.Open();

               reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtTitulo.Text = Convert.ToString(reader["titulo"]);
                    txtTema.Text = Convert.ToString(reader["tema"]);
                    txtAutor.Text = Convert.ToString(reader["Autor"]);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
