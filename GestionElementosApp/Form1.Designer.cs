namespace GestionElementosApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtElemento = new TextBox();
            btnAgregarList = new Button();
            txtValor = new TextBox();
            label2 = new Label();
            btnAgregarDictionary = new Button();
            btnAgregarQueue = new Button();
            btnProcesarQueue = new Button();
            lstColecciones = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Elemento";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(134, 38);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(125, 27);
            txtElemento.TabIndex = 1;
            // 
            // btnAgregarList
            // 
            btnAgregarList.Location = new Point(340, 37);
            btnAgregarList.Name = "btnAgregarList";
            btnAgregarList.Size = new Size(196, 28);
            btnAgregarList.TabIndex = 2;
            btnAgregarList.Text = "Agregar a List";
            btnAgregarList.UseVisualStyleBackColor = true;
            btnAgregarList.Click += btnAgregarList_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(134, 89);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 92);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Valor";
            // 
            // btnAgregarDictionary
            // 
            btnAgregarDictionary.Location = new Point(340, 92);
            btnAgregarDictionary.Name = "btnAgregarDictionary";
            btnAgregarDictionary.Size = new Size(196, 29);
            btnAgregarDictionary.TabIndex = 5;
            btnAgregarDictionary.Text = "Agregar a Dictionary";
            btnAgregarDictionary.UseVisualStyleBackColor = true;
            btnAgregarDictionary.Click += btnAgregarDictionary_Click;
            // 
            // btnAgregarQueue
            // 
            btnAgregarQueue.Location = new Point(62, 157);
            btnAgregarQueue.Name = "btnAgregarQueue";
            btnAgregarQueue.Size = new Size(159, 29);
            btnAgregarQueue.TabIndex = 6;
            btnAgregarQueue.Text = "Agregar a Queue";
            btnAgregarQueue.UseVisualStyleBackColor = true;
            btnAgregarQueue.Click += btnAgregarQueue_Click;
            // 
            // btnProcesarQueue
            // 
            btnProcesarQueue.Location = new Point(319, 157);
            btnProcesarQueue.Name = "btnProcesarQueue";
            btnProcesarQueue.Size = new Size(163, 29);
            btnProcesarQueue.TabIndex = 7;
            btnProcesarQueue.Text = "Procesar Queue";
            btnProcesarQueue.UseVisualStyleBackColor = true;
            btnProcesarQueue.Click += btnProcesarQueue_Click;
            // 
            // lstColecciones
            // 
            lstColecciones.FormattingEnabled = true;
            lstColecciones.Location = new Point(25, 217);
            lstColecciones.Name = "lstColecciones";
            lstColecciones.Size = new Size(511, 184);
            lstColecciones.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 429);
            Controls.Add(lstColecciones);
            Controls.Add(btnProcesarQueue);
            Controls.Add(btnAgregarQueue);
            Controls.Add(btnAgregarDictionary);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(btnAgregarList);
            Controls.Add(txtElemento);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gestión Elementos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtElemento;
        private Button btnAgregarList;
        private TextBox txtValor;
        private Label label2;
        private Button btnAgregarDictionary;
        private Button btnAgregarQueue;
        private Button btnProcesarQueue;
        private ListBox lstColecciones;
    }
}
