
namespace SisFileReader
{
    partial class FileDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDataForm));
            this.grpBoxTitle = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblContratanteName = new System.Windows.Forms.Label();
            this.inputContratanteName = new System.Windows.Forms.TextBox();
            this.inputContratoCodigo = new System.Windows.Forms.TextBox();
            this.lblContratanteDocument = new System.Windows.Forms.Label();
            this.lblContratoCodigo = new System.Windows.Forms.Label();
            this.inputContratanteDocument = new System.Windows.Forms.TextBox();
            this.lblContratadoName = new System.Windows.Forms.Label();
            this.lblContratadoDocument = new System.Windows.Forms.Label();
            this.inputContratadoDocument = new System.Windows.Forms.TextBox();
            this.chxHasDependants = new System.Windows.Forms.CheckBox();
            this.inputContratadoName = new System.Windows.Forms.TextBox();
            this.lblContratadoHasDependants = new System.Windows.Forms.Label();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.btnClearInputs = new System.Windows.Forms.Button();
            this.grpBoxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTitle
            // 
            this.grpBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.grpBoxTitle.Controls.Add(this.lblTitle);
            this.grpBoxTitle.ForeColor = System.Drawing.Color.Transparent;
            this.grpBoxTitle.Location = new System.Drawing.Point(14, 14);
            this.grpBoxTitle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.grpBoxTitle.Name = "grpBoxTitle";
            this.grpBoxTitle.Size = new System.Drawing.Size(772, 72);
            this.grpBoxTitle.TabIndex = 0;
            this.grpBoxTitle.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(271, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FILE DATA GENERATOR";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(14, 89);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblContratanteName);
            this.splitContainer1.Panel1.Controls.Add(this.inputContratanteName);
            this.splitContainer1.Panel1.Controls.Add(this.inputContratoCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.lblContratanteDocument);
            this.splitContainer1.Panel1.Controls.Add(this.lblContratoCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.inputContratanteDocument);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblContratadoName);
            this.splitContainer1.Panel2.Controls.Add(this.lblContratadoDocument);
            this.splitContainer1.Panel2.Controls.Add(this.inputContratadoDocument);
            this.splitContainer1.Panel2.Controls.Add(this.chxHasDependants);
            this.splitContainer1.Panel2.Controls.Add(this.inputContratadoName);
            this.splitContainer1.Panel2.Controls.Add(this.lblContratadoHasDependants);
            this.splitContainer1.Size = new System.Drawing.Size(772, 349);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 15;
            // 
            // lblContratanteName
            // 
            this.lblContratanteName.AutoSize = true;
            this.lblContratanteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContratanteName.ForeColor = System.Drawing.Color.White;
            this.lblContratanteName.Location = new System.Drawing.Point(34, 32);
            this.lblContratanteName.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.lblContratanteName.Name = "lblContratanteName";
            this.lblContratanteName.Size = new System.Drawing.Size(98, 20);
            this.lblContratanteName.TabIndex = 1;
            this.lblContratanteName.Text = "Contratante:";
            // 
            // inputContratanteName
            // 
            this.inputContratanteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.inputContratanteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContratanteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputContratanteName.Location = new System.Drawing.Point(38, 67);
            this.inputContratanteName.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.inputContratanteName.Name = "inputContratanteName";
            this.inputContratanteName.Size = new System.Drawing.Size(300, 26);
            this.inputContratanteName.TabIndex = 2;
            // 
            // inputContratoCodigo
            // 
            this.inputContratoCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.inputContratoCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContratoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputContratoCodigo.Location = new System.Drawing.Point(38, 269);
            this.inputContratoCodigo.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.inputContratoCodigo.Name = "inputContratoCodigo";
            this.inputContratoCodigo.Size = new System.Drawing.Size(300, 26);
            this.inputContratoCodigo.TabIndex = 10;
            // 
            // lblContratanteDocument
            // 
            this.lblContratanteDocument.AutoSize = true;
            this.lblContratanteDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContratanteDocument.ForeColor = System.Drawing.Color.White;
            this.lblContratanteDocument.Location = new System.Drawing.Point(34, 133);
            this.lblContratanteDocument.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.lblContratanteDocument.Name = "lblContratanteDocument";
            this.lblContratanteDocument.Size = new System.Drawing.Size(204, 20);
            this.lblContratanteDocument.TabIndex = 5;
            this.lblContratanteDocument.Text = "Documento do contratante:";
            // 
            // lblContratoCodigo
            // 
            this.lblContratoCodigo.AutoSize = true;
            this.lblContratoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContratoCodigo.ForeColor = System.Drawing.Color.White;
            this.lblContratoCodigo.Location = new System.Drawing.Point(34, 234);
            this.lblContratoCodigo.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.lblContratoCodigo.Name = "lblContratoCodigo";
            this.lblContratoCodigo.Size = new System.Drawing.Size(151, 20);
            this.lblContratoCodigo.TabIndex = 9;
            this.lblContratoCodigo.Text = "Código do Contrato:";
            // 
            // inputContratanteDocument
            // 
            this.inputContratanteDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.inputContratanteDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContratanteDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputContratanteDocument.Location = new System.Drawing.Point(38, 168);
            this.inputContratanteDocument.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.inputContratanteDocument.Name = "inputContratanteDocument";
            this.inputContratanteDocument.Size = new System.Drawing.Size(300, 26);
            this.inputContratanteDocument.TabIndex = 6;
            // 
            // lblContratadoName
            // 
            this.lblContratadoName.AutoSize = true;
            this.lblContratadoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContratadoName.ForeColor = System.Drawing.Color.White;
            this.lblContratadoName.Location = new System.Drawing.Point(48, 32);
            this.lblContratadoName.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.lblContratadoName.Name = "lblContratadoName";
            this.lblContratadoName.Size = new System.Drawing.Size(93, 20);
            this.lblContratadoName.TabIndex = 3;
            this.lblContratadoName.Text = "Contratado:";
            // 
            // lblContratadoDocument
            // 
            this.lblContratadoDocument.AutoSize = true;
            this.lblContratadoDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContratadoDocument.ForeColor = System.Drawing.Color.White;
            this.lblContratadoDocument.Location = new System.Drawing.Point(48, 133);
            this.lblContratadoDocument.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.lblContratadoDocument.Name = "lblContratadoDocument";
            this.lblContratadoDocument.Size = new System.Drawing.Size(199, 20);
            this.lblContratadoDocument.TabIndex = 7;
            this.lblContratadoDocument.Text = "Documento do contratado:";
            // 
            // inputContratadoDocument
            // 
            this.inputContratadoDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.inputContratadoDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContratadoDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputContratadoDocument.Location = new System.Drawing.Point(52, 168);
            this.inputContratadoDocument.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.inputContratadoDocument.Name = "inputContratadoDocument";
            this.inputContratadoDocument.Size = new System.Drawing.Size(300, 26);
            this.inputContratadoDocument.TabIndex = 8;
            // 
            // chxHasDependants
            // 
            this.chxHasDependants.AutoSize = true;
            this.chxHasDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.chxHasDependants.ForeColor = System.Drawing.Color.White;
            this.chxHasDependants.Location = new System.Drawing.Point(232, 238);
            this.chxHasDependants.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.chxHasDependants.Name = "chxHasDependants";
            this.chxHasDependants.Size = new System.Drawing.Size(15, 14);
            this.chxHasDependants.TabIndex = 12;
            this.chxHasDependants.UseVisualStyleBackColor = true;
            // 
            // inputContratadoName
            // 
            this.inputContratadoName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.inputContratadoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputContratadoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.inputContratadoName.Location = new System.Drawing.Point(52, 67);
            this.inputContratadoName.Margin = new System.Windows.Forms.Padding(5, 10, 10, 5);
            this.inputContratadoName.Name = "inputContratadoName";
            this.inputContratadoName.Size = new System.Drawing.Size(300, 26);
            this.inputContratadoName.TabIndex = 4;
            // 
            // lblContratadoHasDependants
            // 
            this.lblContratadoHasDependants.AutoSize = true;
            this.lblContratadoHasDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblContratadoHasDependants.ForeColor = System.Drawing.Color.White;
            this.lblContratadoHasDependants.Location = new System.Drawing.Point(48, 234);
            this.lblContratadoHasDependants.Margin = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.lblContratadoHasDependants.Name = "lblContratadoHasDependants";
            this.lblContratadoHasDependants.Size = new System.Drawing.Size(163, 20);
            this.lblContratadoHasDependants.TabIndex = 11;
            this.lblContratadoHasDependants.Text = "Possui dependentes?";
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(208)))), ((int)(((byte)(11)))));
            this.btnGenerateFile.FlatAppearance.BorderSize = 0;
            this.btnGenerateFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(3)))));
            this.btnGenerateFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(6)))));
            this.btnGenerateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnGenerateFile.ForeColor = System.Drawing.Color.White;
            this.btnGenerateFile.Location = new System.Drawing.Point(325, 451);
            this.btnGenerateFile.Margin = new System.Windows.Forms.Padding(10);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(150, 35);
            this.btnGenerateFile.TabIndex = 16;
            this.btnGenerateFile.Text = "Gerar dados";
            this.btnGenerateFile.UseVisualStyleBackColor = false;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // btnClearInputs
            // 
            this.btnClearInputs.BackColor = System.Drawing.Color.Transparent;
            this.btnClearInputs.FlatAppearance.BorderSize = 0;
            this.btnClearInputs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnClearInputs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.btnClearInputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClearInputs.ForeColor = System.Drawing.Color.White;
            this.btnClearInputs.Image = ((System.Drawing.Image)(resources.GetObject("btnClearInputs.Image")));
            this.btnClearInputs.Location = new System.Drawing.Point(495, 451);
            this.btnClearInputs.Margin = new System.Windows.Forms.Padding(10);
            this.btnClearInputs.Name = "btnClearInputs";
            this.btnClearInputs.Size = new System.Drawing.Size(35, 35);
            this.btnClearInputs.TabIndex = 17;
            this.btnClearInputs.UseVisualStyleBackColor = false;
            this.btnClearInputs.Click += new System.EventHandler(this.btnClearInputs_Click);
            // 
            // FileDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnClearInputs);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.grpBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FileDataForm";
            this.Text = "FileGenerator";
            this.grpBoxTitle.ResumeLayout(false);
            this.grpBoxTitle.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblContratanteName;
        private System.Windows.Forms.TextBox inputContratanteName;
        private System.Windows.Forms.TextBox inputContratoCodigo;
        private System.Windows.Forms.Label lblContratanteDocument;
        private System.Windows.Forms.Label lblContratoCodigo;
        private System.Windows.Forms.TextBox inputContratanteDocument;
        private System.Windows.Forms.Label lblContratadoName;
        private System.Windows.Forms.Label lblContratadoDocument;
        private System.Windows.Forms.TextBox inputContratadoDocument;
        private System.Windows.Forms.CheckBox chxHasDependants;
        private System.Windows.Forms.TextBox inputContratadoName;
        private System.Windows.Forms.Label lblContratadoHasDependants;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Button btnClearInputs;
    }
}