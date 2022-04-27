using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SisFileReader
{
    public partial class FileDataForm : Form
    {
        #region CONSTRUCTOR

        public FileDataForm()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTOR


        #region VARIABLES

        public string contratanteNome = "";
        public string contratanteDocumento = "";
        public string contratoCodigo = "";

        public string contratadoNome = "";
        public string contratadoDocumento = "";
        public bool contratadoStatus = false;

        #endregion VARIABLES


        #region BUTTON METHODS

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            StreamWriter fileWriter = new StreamWriter(Application.StartupPath + "\\files\\" + "dadosContrato.txt");
            
            if (inputContratanteName.Text != "" || inputContratanteDocument.Text != "" || inputContratoCodigo.Text != "")
            {
                if (inputContratadoName.Text != "" || inputContratadoDocument.Text != "")
                {
                    contratanteNome = inputContratanteName.Text;
                    contratanteDocumento = inputContratanteDocument.Text;
                    contratoCodigo = inputContratoCodigo.Text;

                    contratadoNome = inputContratadoName.Text;
                    contratadoDocumento = inputContratadoDocument.Text;
                    contratadoStatus = chxHasDependants.Checked;

                    fileWriter.WriteLine(lblContratanteName.Text + " " + contratanteNome);
                    fileWriter.WriteLine(lblContratanteDocument.Text + " " + contratanteDocumento);
                    fileWriter.WriteLine(lblContratoCodigo.Text + " " + contratoCodigo);
                    fileWriter.WriteLine();
                    fileWriter.WriteLine(lblContratadoName.Text + " " + contratadoNome);
                    fileWriter.WriteLine(lblContratadoDocument.Text + " " + contratadoDocumento);
                    fileWriter.WriteLine(lblContratadoHasDependants.Text + " " + this.YesOrNoAnswer(contratadoStatus));

                    fileWriter.Close();
                }
            }
        }

        private void btnClearInputs_Click(object sender, EventArgs e)
        {
            inputContratanteName.Text = "";
            inputContratanteDocument.Text = "";
            inputContratoCodigo.Text = "";

            inputContratadoName.Text = "";
            inputContratadoDocument.Text = "";
            chxHasDependants.Checked = false;
        }

        #endregion BUTTON METHODS


        #region PRIVATE METHODS

        /// <summary>
        /// Método que gera uma resposta de "Sim" ou "Não" baseado no estado de um booleano.
        /// </summary>
        /// <param name="isChecked">Booleano que será avaliado para gerar a resposta.</param>
        /// <param name="afirmacao">(Opcional) Resposta customizada em caso de true.</param>
        /// <param name="negacao">(Opcional) Resposta customizada em caso de false.</param>
        /// <returns>"Sim" se o Booleano for <code>- true</code> "Não" se o Booleano for <code>- false</code></returns>
        public string YesOrNoAnswer(bool isChecked, string afirmacao = "", string negacao = "")
        {
            string resposta = "";
            
            if (this.IsNullOrEmpty(afirmacao) || this.IsNullOrEmpty(negacao))
            {
                resposta = isChecked ? "Sim" : "Não";
            } 
            
            else
            {
                resposta = isChecked ? afirmacao : negacao;
            }

            return resposta;
        }

        /// <summary>
        /// Verifica se uma string é nula ou vazia.
        /// </summary>
        /// <param name="text">String que será verificada.</param>
        /// <returns>Se a String for vazia ou nula retorna <code>- true</code> Caso contrário retorna <code>- false</code></returns>
        public bool IsNullOrEmpty(string text)
        {
            if (text == "" || text == null)
            {
                return true;
            }

            return false;
        }

        #endregion PRIVATE METHODS
    }
}
