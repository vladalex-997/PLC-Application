
namespace proiectPLC
{
    partial class FormPLC
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
            this.labelLastValue = new System.Windows.Forms.Label();
            this.textBoxLastValue = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLastValue
            // 
            this.labelLastValue.AutoSize = true;
            this.labelLastValue.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelLastValue.Location = new System.Drawing.Point(975, 21);
            this.labelLastValue.Name = "labelLastValue";
            this.labelLastValue.Size = new System.Drawing.Size(420, 68);
            this.labelLastValue.TabIndex = 6;
            this.labelLastValue.Text = "Last Read Value";
            this.labelLastValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxLastValue
            // 
            this.textBoxLastValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxLastValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastValue.Font = new System.Drawing.Font("Times New Roman", 96F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastValue.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxLastValue.Location = new System.Drawing.Point(514, 182);
            this.textBoxLastValue.Name = "textBoxLastValue";
            this.textBoxLastValue.ReadOnly = true;
            this.textBoxLastValue.Size = new System.Drawing.Size(1353, 184);
            this.textBoxLastValue.TabIndex = 7;
            this.textBoxLastValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelDescription.Location = new System.Drawing.Point(902, 403);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(592, 68);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Last Value Description ";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Times New Roman", 39F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxDescription.Location = new System.Drawing.Point(434, 527);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(1463, 399);
            this.textBoxDescription.TabIndex = 9;
            this.textBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(778, 929);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(847, 57);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "Warning ! Possible Consecutive Values";
            this.labelError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Yellow;
            this.labelStatus.Location = new System.Drawing.Point(74, 939);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(380, 46);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status Conexiune PLC";
            // 
            // FormPLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1924, 1023);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxLastValue);
            this.Controls.Add(this.labelLastValue);
            this.Name = "FormPLC";
            this.Text = "PLC Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPLC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLastValue;
        private System.Windows.Forms.TextBox textBoxLastValue;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelStatus;
    }
}

