using System.Drawing;

namespace Contagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.countContainer = new System.Windows.Forms.Panel();
            this.numberCount0 = new System.Windows.Forms.Label();
            this.countTrack = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.messageContainer = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.copyright = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.powerBtn = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainContainer.SuspendLayout();
            this.countContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-228, -175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1529, 915);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.title.Font = new System.Drawing.Font("Unispace", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(452, 42);
            this.title.TabIndex = 1;
            this.title.Text = "CONTADOR ULTIMATE 2000";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold);
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(22, 334);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Count++";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addCount);
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.mainContainer.Controls.Add(this.subtitle);
            this.mainContainer.Controls.Add(this.countContainer);
            this.mainContainer.Controls.Add(this.countTrack);
            this.mainContainer.Controls.Add(this.labelLine);
            this.mainContainer.Controls.Add(this.messageContainer);
            this.mainContainer.Controls.Add(this.resetButton);
            this.mainContainer.Controls.Add(this.copyright);
            this.mainContainer.Controls.Add(this.addButton);
            this.mainContainer.Controls.Add(this.title);
            this.mainContainer.Location = new System.Drawing.Point(305, 128);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(452, 415);
            this.mainContainer.TabIndex = 3;
            // 
            // countContainer
            // 
            this.countContainer.Controls.Add(this.numberCount0);
            this.countContainer.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.countContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.countContainer.Location = new System.Drawing.Point(403, 335);
            this.countContainer.Name = "countContainer";
            this.countContainer.Size = new System.Drawing.Size(35, 35);
            this.countContainer.TabIndex = 7;
            // 
            // numberCount0
            // 
            this.numberCount0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.numberCount0.Location = new System.Drawing.Point(0, 0);
            this.numberCount0.Name = "numberCount0";
            this.numberCount0.Size = new System.Drawing.Size(35, 35);
            this.numberCount0.TabIndex = 0;
            this.numberCount0.Text = "0";
            this.numberCount0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countTrack
            // 
            this.countTrack.Font = new System.Drawing.Font("Unispace", 10F, System.Drawing.FontStyle.Bold);
            this.countTrack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.countTrack.Location = new System.Drawing.Point(304, 335);
            this.countTrack.Name = "countTrack";
            this.countTrack.Size = new System.Drawing.Size(99, 36);
            this.countTrack.TabIndex = 6;
            this.countTrack.Text = "Count =";
            this.countTrack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLine
            // 
            this.labelLine.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLine.ForeColor = System.Drawing.Color.Silver;
            this.labelLine.Location = new System.Drawing.Point(3, 78);
            this.labelLine.Name = "labelLine";
            this.labelLine.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelLine.Size = new System.Drawing.Size(443, 18);
            this.labelLine.TabIndex = 0;
            this.labelLine.Text = "Clique⠀no⠀botão⠀Count++⠀para⠀começar";
            this.labelLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageContainer
            // 
            this.messageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageContainer.Location = new System.Drawing.Point(3, 99);
            this.messageContainer.Name = "messageContainer";
            this.messageContainer.Size = new System.Drawing.Size(446, 229);
            this.messageContainer.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Unispace", 8F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.resetButton.Location = new System.Drawing.Point(120, 334);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 36);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetCount);
            // 
            // copyright
            // 
            this.copyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.copyright.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.Silver;
            this.copyright.Location = new System.Drawing.Point(0, 376);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(449, 28);
            this.copyright.TabIndex = 3;
            this.copyright.Text = "Todos os direitos reservados © Lucas Cardoso 2021102487";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTimer
            // 
            this.labelTimer.Enabled = true;
            this.labelTimer.Interval = 10;
            this.labelTimer.Tick += new System.EventHandler(this.labelAnimation);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // powerBtn
            // 
            this.powerBtn.BackColor = System.Drawing.Color.Transparent;
            this.powerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerBtn.ForeColor = System.Drawing.Color.BlueViolet;
            this.powerBtn.Location = new System.Drawing.Point(761, 601);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(42, 38);
            this.powerBtn.TabIndex = 4;
            this.powerBtn.Click += new System.EventHandler(this.powerBtn_Click);
            // 
            // subtitle
            // 
            this.subtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subtitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.subtitle.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle.ForeColor = System.Drawing.Color.Green;
            this.subtitle.Location = new System.Drawing.Point(91, 42);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(271, 25);
            this.subtitle.TabIndex = 8;
            this.subtitle.Text = "8 Bits Edition";
            this.subtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(1087, 712);
            this.Controls.Add(this.powerBtn);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1044, 717);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.countContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel messageContainer;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Timer labelTimer;
        private System.Windows.Forms.Label powerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label powerBtn;
        private System.Windows.Forms.Label countTrack;
        private System.Windows.Forms.Panel countContainer;
        private System.Windows.Forms.Label numberCount0;
        private System.Windows.Forms.Label subtitle;
    }
}

