
namespace TRBD
{
    partial class FormWorcerAutification
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Parol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAutification = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(133, 125);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(312, 38);
            this.Login.TabIndex = 0;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Parol
            // 
            this.Parol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Parol.Location = new System.Drawing.Point(133, 175);
            this.Parol.Name = "Parol";
            this.Parol.Size = new System.Drawing.Size(312, 38);
            this.Parol.TabIndex = 1;
            this.Parol.TextChanged += new System.EventHandler(this.Parol_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // buttonAutification
            // 
            this.buttonAutification.Location = new System.Drawing.Point(133, 234);
            this.buttonAutification.Name = "buttonAutification";
            this.buttonAutification.Size = new System.Drawing.Size(312, 56);
            this.buttonAutification.TabIndex = 4;
            this.buttonAutification.Text = "Войти";
            this.buttonAutification.UseVisualStyleBackColor = true;
            this.buttonAutification.Click += new System.EventHandler(this.buttonAutification_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // FormWorcerAutification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 349);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.buttonAutification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Parol);
            this.Controls.Add(this.Login);
            this.Name = "FormWorcerAutification";
            this.Text = "FormWorcerAutification";
            this.Load += new System.EventHandler(this.FormWorcerAutification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Parol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAutification;
        private System.Windows.Forms.Button Back;
    }
}