namespace RoachProj
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainButon = new System.Windows.Forms.Button();
            this.playerSelect = new System.Windows.Forms.ComboBox();
            this.roachOneBet = new System.Windows.Forms.TextBox();
            this.roachTwoBet = new System.Windows.Forms.TextBox();
            this.roachThreeBet = new System.Windows.Forms.TextBox();
            this.roachFourBet = new System.Windows.Forms.TextBox();
            this.moneyText = new System.Windows.Forms.Label();
            this.valueMoney = new System.Windows.Forms.Label();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.onePic = new System.Windows.Forms.PictureBox();
            this.twoPic = new System.Windows.Forms.PictureBox();
            this.threePic = new System.Windows.Forms.PictureBox();
            this.fourPic = new System.Windows.Forms.PictureBox();
            this.finishPic = new System.Windows.Forms.PictureBox();
            this.betButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.onePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainButon
            // 
            this.mainButon.Location = new System.Drawing.Point(73, 12);
            this.mainButon.Name = "mainButon";
            this.mainButon.Size = new System.Drawing.Size(60, 23);
            this.mainButon.TabIndex = 0;
            this.mainButon.Text = "Start";
            this.mainButon.UseVisualStyleBackColor = true;
            this.mainButon.Click += new System.EventHandler(this.mainButon_Click);
            // 
            // playerSelect
            // 
            this.playerSelect.FormattingEnabled = true;
            this.playerSelect.Location = new System.Drawing.Point(12, 41);
            this.playerSelect.Name = "playerSelect";
            this.playerSelect.Size = new System.Drawing.Size(121, 21);
            this.playerSelect.TabIndex = 1;
            this.playerSelect.Text = "Choose player";
            this.playerSelect.SelectedIndexChanged += new System.EventHandler(this.playerSelect_SelectedIndexChanged);
            // 
            // roachOneBet
            // 
            this.roachOneBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roachOneBet.Location = new System.Drawing.Point(12, 68);
            this.roachOneBet.Name = "roachOneBet";
            this.roachOneBet.Size = new System.Drawing.Size(121, 13);
            this.roachOneBet.TabIndex = 2;
            this.roachOneBet.Text = "0";
            // 
            // roachTwoBet
            // 
            this.roachTwoBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roachTwoBet.Location = new System.Drawing.Point(12, 94);
            this.roachTwoBet.Name = "roachTwoBet";
            this.roachTwoBet.Size = new System.Drawing.Size(121, 13);
            this.roachTwoBet.TabIndex = 3;
            this.roachTwoBet.Text = "0";
            // 
            // roachThreeBet
            // 
            this.roachThreeBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roachThreeBet.Location = new System.Drawing.Point(12, 120);
            this.roachThreeBet.Name = "roachThreeBet";
            this.roachThreeBet.Size = new System.Drawing.Size(121, 13);
            this.roachThreeBet.TabIndex = 4;
            this.roachThreeBet.Text = "0";
            // 
            // roachFourBet
            // 
            this.roachFourBet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roachFourBet.Location = new System.Drawing.Point(12, 146);
            this.roachFourBet.Name = "roachFourBet";
            this.roachFourBet.Size = new System.Drawing.Size(121, 13);
            this.roachFourBet.TabIndex = 5;
            this.roachFourBet.Text = "0";
            // 
            // moneyText
            // 
            this.moneyText.AutoSize = true;
            this.moneyText.Location = new System.Drawing.Point(9, 162);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(84, 13);
            this.moneyText.TabIndex = 6;
            this.moneyText.Text = "Player\'s balance";
            // 
            // valueMoney
            // 
            this.valueMoney.AutoSize = true;
            this.valueMoney.Location = new System.Drawing.Point(99, 162);
            this.valueMoney.Name = "valueMoney";
            this.valueMoney.Size = new System.Drawing.Size(13, 13);
            this.valueMoney.TabIndex = 7;
            this.valueMoney.Text = "0";
            // 
            // ticker
            // 
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // onePic
            // 
            this.onePic.Image = ((System.Drawing.Image)(resources.GetObject("onePic.Image")));
            this.onePic.Location = new System.Drawing.Point(139, 68);
            this.onePic.Name = "onePic";
            this.onePic.Size = new System.Drawing.Size(23, 14);
            this.onePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onePic.TabIndex = 8;
            this.onePic.TabStop = false;
            // 
            // twoPic
            // 
            this.twoPic.Image = ((System.Drawing.Image)(resources.GetObject("twoPic.Image")));
            this.twoPic.Location = new System.Drawing.Point(139, 94);
            this.twoPic.Name = "twoPic";
            this.twoPic.Size = new System.Drawing.Size(23, 14);
            this.twoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoPic.TabIndex = 8;
            this.twoPic.TabStop = false;
            // 
            // threePic
            // 
            this.threePic.Image = ((System.Drawing.Image)(resources.GetObject("threePic.Image")));
            this.threePic.Location = new System.Drawing.Point(139, 120);
            this.threePic.Name = "threePic";
            this.threePic.Size = new System.Drawing.Size(23, 14);
            this.threePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threePic.TabIndex = 8;
            this.threePic.TabStop = false;
            // 
            // fourPic
            // 
            this.fourPic.Image = ((System.Drawing.Image)(resources.GetObject("fourPic.Image")));
            this.fourPic.Location = new System.Drawing.Point(139, 146);
            this.fourPic.Name = "fourPic";
            this.fourPic.Size = new System.Drawing.Size(23, 14);
            this.fourPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fourPic.TabIndex = 8;
            this.fourPic.TabStop = false;
            // 
            // finishPic
            // 
            this.finishPic.Image = ((System.Drawing.Image)(resources.GetObject("finishPic.Image")));
            this.finishPic.Location = new System.Drawing.Point(427, 66);
            this.finishPic.Name = "finishPic";
            this.finishPic.Size = new System.Drawing.Size(21, 93);
            this.finishPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finishPic.TabIndex = 9;
            this.finishPic.TabStop = false;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(12, 12);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(60, 23);
            this.betButton.TabIndex = 10;
            this.betButton.Text = "Bet";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 183);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.finishPic);
            this.Controls.Add(this.fourPic);
            this.Controls.Add(this.threePic);
            this.Controls.Add(this.twoPic);
            this.Controls.Add(this.onePic);
            this.Controls.Add(this.valueMoney);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.roachFourBet);
            this.Controls.Add(this.roachThreeBet);
            this.Controls.Add(this.roachTwoBet);
            this.Controls.Add(this.roachOneBet);
            this.Controls.Add(this.playerSelect);
            this.Controls.Add(this.mainButon);
            this.Name = "Form1";
            this.Text = "Running roaches";
            ((System.ComponentModel.ISupportInitialize)(this.onePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButon;
        private System.Windows.Forms.ComboBox playerSelect;
        private System.Windows.Forms.TextBox roachOneBet;
        private System.Windows.Forms.TextBox roachTwoBet;
        private System.Windows.Forms.TextBox roachThreeBet;
        private System.Windows.Forms.TextBox roachFourBet;
        private System.Windows.Forms.Label moneyText;
        private System.Windows.Forms.Label valueMoney;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.PictureBox onePic;
        private System.Windows.Forms.PictureBox twoPic;
        private System.Windows.Forms.PictureBox threePic;
        private System.Windows.Forms.PictureBox fourPic;
        private System.Windows.Forms.PictureBox finishPic;
        private System.Windows.Forms.Button betButton;
    }
}

