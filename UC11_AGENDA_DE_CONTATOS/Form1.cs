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

namespace UC11_AGENDA_DE_CONTATOS
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public Form1()
        {
            InitializeComponent();
            textBoxID.Enabled = false;

            servidor = "Server=localhost;Database=agenda_contatos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            mostrar_contatosdataGRID();
        }

        private void mostrar_contatosdataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM tbl_agenda;";

                MySqlDataAdapter adaptadorCONTATO = new MySqlDataAdapter(comando);

                DataTable tabelaCONTATO = new DataTable();
                adaptadorCONTATO.Fill(tabelaCONTATO);

                dataGridViewPESQUISA.DataSource = tabelaCONTATO;
                dataGridViewPESQUISA.Columns["id"].HeaderText = "código";
                dataGridViewPESQUISA.Columns["email"].HeaderText = "e-mail";
                


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
            
        }

        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            bool novo_contato = true;

            string situaca = "desbloqueado";

            if (radioButtonDESBLOQUEADO.Checked)
            {

            }

            if (radioButtonBLOQUEADO.Checked)
            {
                situaca = "bloqueado";
            }

            if (textBoxNOME.Text != ""  && textBoxCELULAR.Text != "" && situaca != "") {

                try
                {
                    conexao.Open();
                    comando.CommandText = "SELECT agenda_contatos FROM tbl_agenda WHERE nome, sobrenome, celular = '" + textBoxNOME.Text + "'; '" + textBoxSOBRENOME.Text + "', '" + textBoxCELULAR.Text + "';";

                    MySqlDataReader valida_produto = comando.ExecuteReader();

                    if (valida_produto.Read())
                    {
                        novo_contato = false;
                        MessageBox.Show("Contato já cadastrado");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    //MessageBox.Show("Erro ao cadastrar novo contato. Fale com o administrador do sistema");
                }
                finally
                {
                    conexao.Close();
                }


                //-------//



                string situacao = "desbloqueado";

                if (radioButtonDESBLOQUEADO.Checked)
                {

                }

                if (radioButtonBLOQUEADO.Checked)
                {
                    situacao = "bloqueado";
                }

                try
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_agenda (nome, sobrenome, telefone, celular, email, linkdin, atividade) VALUES ('" + textBoxNOME.Text + "', '" + textBoxSOBRENOME.Text + "','" + textBoxTELEFONE.Text + "', '" + textBoxCELULAR.Text + "', '" + textBoxEMAIL.Text + "', '" + textBoxLINKEDIN.Text + "', '" + situacao + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    //MessageBox.Show("Erro ao cadastrar produto!");
                }
                finally
                {
                    conexao.Close();
                }
                mostrar_contatosdataGRID();
            }
            else
            {
                MessageBox.Show("preencha os campos em branco!");
            }
        }

        private void radioButtonDESBLOQUEADO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonEXCLUIR_Click(object sender, EventArgs e)
        {
            try
            {

                conexao.Open();
                comando.CommandText = "DELETE FROM tbl_agenda WHERE id = '" + textBoxID.Text + "';";
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso!");


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Erro ao excluir produto. Tente Novamente");
            }
            finally
            {
                conexao.Close();
            }
            mostrar_contatosdataGRID();
        }

        private void dataGridViewPESQUISA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewPESQUISA_MouseClick(object sender, MouseEventArgs e)
        {
            string situacao = "desbloqueado";

            if (radioButtonDESBLOQUEADO.Checked)
            {

            }

            if (radioButtonBLOQUEADO.Checked)
            {
                situacao = "bloqueado";
            }

            textBoxID.Text = dataGridViewPESQUISA.CurrentRow.Cells[0].Value.ToString();
            textBoxNOME.Text = dataGridViewPESQUISA.CurrentRow.Cells[1].Value.ToString();
            textBoxSOBRENOME.Text = dataGridViewPESQUISA.CurrentRow.Cells[2].Value.ToString();
            textBoxTELEFONE.Text = dataGridViewPESQUISA.CurrentRow.Cells[3].Value.ToString();
            textBoxCELULAR.Text = dataGridViewPESQUISA.CurrentRow.Cells[4].Value.ToString();
            textBoxEMAIL.Text = dataGridViewPESQUISA.CurrentRow.Cells[5].Value.ToString();
            textBoxLINKEDIN.Text = dataGridViewPESQUISA.CurrentRow.Cells[6].Value.ToString();
            situacao = dataGridViewPESQUISA.CurrentRow.Cells[7].Value.ToString();
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            string situacao = "desbloqueado";

            if (radioButtonDESBLOQUEADO.Checked)
            {

            }

            if (radioButtonBLOQUEADO.Checked)
            {
                situacao = "bloqueado";
            }

            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE tbl_agenda SET nome = '"+ textBoxNOME.Text +"', sobrenome = '"+ textBoxSOBRENOME.Text +"', telefone = '"+ textBoxTELEFONE.Text +"', celular = '"+ textBoxCELULAR.Text +"', email = '"+ textBoxEMAIL.Text +"', linkdin = '"+ textBoxLINKEDIN.Text +"', atividade = '" + situacao + "' id = '"+ textBoxID.Text +"';";
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato atualizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Erro ao atualizar o contato!");
            }
            finally
            {
                conexao.Close();
            }
            mostrar_contatosdataGRID();
        }

        private void buttonPESQUISAR_Click(object sender, EventArgs e)
        {
            textBoxNOME.Text = dataGridViewPESQUISA.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
