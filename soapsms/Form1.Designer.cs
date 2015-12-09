namespace soapsms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ENVIAR = new System.Windows.Forms.Button();
            this.labelFone = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.textBoxFone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ENVIAR
            // 
            this.ENVIAR.Location = new System.Drawing.Point(104, 238);
            this.ENVIAR.Name = "ENVIAR";
            this.ENVIAR.Size = new System.Drawing.Size(75, 23);
            this.ENVIAR.TabIndex = 2;
            this.ENVIAR.Text = "ENVIAR";
            this.ENVIAR.UseVisualStyleBackColor = true;
            this.ENVIAR.Click += new System.EventHandler(this.ENVIAR_Click);
            // 
            // labelFone
            // 
            this.labelFone.AutoSize = true;
            this.labelFone.Location = new System.Drawing.Point(11, 9);
            this.labelFone.Name = "labelFone";
            this.labelFone.Size = new System.Drawing.Size(52, 13);
            this.labelFone.TabIndex = 1;
            this.labelFone.Text = "Telefone:";
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(11, 59);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(62, 13);
            this.labelMsg.TabIndex = 2;
            this.labelMsg.Text = "Mensagem:";
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Location = new System.Drawing.Point(12, 75);
            this.textBoxMsg.MaxLength = 160;
            this.textBoxMsg.Multiline = true;
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.Size = new System.Drawing.Size(268, 157);
            this.textBoxMsg.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(91, 238);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(38, 261);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(35, 13);
            this.progressLabel.TabIndex = 6;
            this.progressLabel.Text = "label1";
            this.progressLabel.Visible = false;
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(14, 25);
            this.textBoxFone.Mask = "(999) 0000-0000";
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(87, 20);
            this.textBoxFone.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 283);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.labelFone);
            this.Controls.Add(this.ENVIAR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SOAPsms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ENVIAR;
        private System.Windows.Forms.Label labelFone;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.MaskedTextBox textBoxFone;
    }
}

