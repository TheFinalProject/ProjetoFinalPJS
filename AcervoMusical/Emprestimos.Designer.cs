namespace AcervoMusical
{
    partial class Emprestimos
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
            this.comboBox_NomeAmigo = new System.Windows.Forms.ComboBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NomeAmigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeAblum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataEmprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_emprestimo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_NomeAmigo
            // 
            this.comboBox_NomeAmigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_NomeAmigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_NomeAmigo.FormattingEnabled = true;
            this.comboBox_NomeAmigo.Location = new System.Drawing.Point(10, 51);
            this.comboBox_NomeAmigo.Name = "comboBox_NomeAmigo";
            this.comboBox_NomeAmigo.Size = new System.Drawing.Size(201, 21);
            this.comboBox_NomeAmigo.TabIndex = 0;
            this.comboBox_NomeAmigo.SelectedIndexChanged += new System.EventHandler(this.comboBox_NomeAmigo_SelectedIndexChanged);
            this.comboBox_NomeAmigo.TextChanged += new System.EventHandler(this.comboBox_NomeAmigo_TextChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(10, 35);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(67, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome Amigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Album";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(321, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(298, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emprestar";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeAmigo,
            this.NomeAblum,
            this.DataEmprestimo});
            this.listView1.Location = new System.Drawing.Point(7, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 316);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NomeAmigo
            // 
            this.NomeAmigo.Text = "Nome Amigo";
            this.NomeAmigo.Width = 275;
            // 
            // NomeAblum
            // 
            this.NomeAblum.Text = "Nome Album";
            this.NomeAblum.Width = 304;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.Text = "Data Emprestimo";
            this.DataEmprestimo.Width = 175;
            // 
            // dateTimePicker_emprestimo
            // 
            this.dateTimePicker_emprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_emprestimo.Location = new System.Drawing.Point(649, 51);
            this.dateTimePicker_emprestimo.Name = "dateTimePicker_emprestimo";
            this.dateTimePicker_emprestimo.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker_emprestimo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de emprestimo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 456);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.dateTimePicker_emprestimo);
            this.tabPage1.Controls.Add(this.comboBox_NomeAmigo);
            this.tabPage1.Controls.Add(this.Nome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emprestimos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devoluções";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Emprestimos";
            this.Load += new System.EventHandler(this.Emprestimos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_NomeAmigo;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_emprestimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColumnHeader NomeAmigo;
        private System.Windows.Forms.ColumnHeader NomeAblum;
        private System.Windows.Forms.ColumnHeader DataEmprestimo;
        private System.Windows.Forms.TabPage tabPage2;
    }
}