
namespace Weather_API
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
            this.lblCity = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWindSpeedKph = new System.Windows.Forms.Label();
            this.lblWindSpeedMph = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtWindSpdKph = new System.Windows.Forms.TextBox();
            this.txtWindSpdMph = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.picCloud = new System.Windows.Forms.PictureBox();
            this.lblCloudState = new System.Windows.Forms.Label();
            this.btnShowCloud = new System.Windows.Forms.Button();
            this.dgvDays = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(306, 12);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(306, 58);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(68, 17);
            this.lblMaxTemp.TabIndex = 1;
            this.lblMaxTemp.Text = "Max temp";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(306, 170);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(62, 17);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblWindSpeedKph
            // 
            this.lblWindSpeedKph.AutoSize = true;
            this.lblWindSpeedKph.Location = new System.Drawing.Point(306, 142);
            this.lblWindSpeedKph.Name = "lblWindSpeedKph";
            this.lblWindSpeedKph.Size = new System.Drawing.Size(110, 17);
            this.lblWindSpeedKph.TabIndex = 3;
            this.lblWindSpeedKph.Text = "Wind speed kph";
            // 
            // lblWindSpeedMph
            // 
            this.lblWindSpeedMph.AutoSize = true;
            this.lblWindSpeedMph.Location = new System.Drawing.Point(306, 114);
            this.lblWindSpeedMph.Name = "lblWindSpeedMph";
            this.lblWindSpeedMph.Size = new System.Drawing.Size(114, 17);
            this.lblWindSpeedMph.TabIndex = 4;
            this.lblWindSpeedMph.Text = "Wind speed mph";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(306, 86);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(65, 17);
            this.lblMinTemp.TabIndex = 5;
            this.lblMinTemp.Text = "Min temp";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(479, 12);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(162, 22);
            this.txtCity.TabIndex = 6;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(479, 170);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(162, 22);
            this.txtHumidity.TabIndex = 7;
            // 
            // txtWindSpdKph
            // 
            this.txtWindSpdKph.Location = new System.Drawing.Point(479, 142);
            this.txtWindSpdKph.Name = "txtWindSpdKph";
            this.txtWindSpdKph.Size = new System.Drawing.Size(162, 22);
            this.txtWindSpdKph.TabIndex = 8;
            // 
            // txtWindSpdMph
            // 
            this.txtWindSpdMph.Location = new System.Drawing.Point(479, 114);
            this.txtWindSpdMph.Name = "txtWindSpdMph";
            this.txtWindSpdMph.Size = new System.Drawing.Size(162, 22);
            this.txtWindSpdMph.TabIndex = 9;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(479, 86);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(162, 22);
            this.txtMinTemp.TabIndex = 10;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(479, 58);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(162, 22);
            this.txtMaxTemp.TabIndex = 11;
            // 
            // picCloud
            // 
            this.picCloud.Location = new System.Drawing.Point(982, 12);
            this.picCloud.Name = "picCloud";
            this.picCloud.Size = new System.Drawing.Size(188, 188);
            this.picCloud.TabIndex = 12;
            this.picCloud.TabStop = false;
            // 
            // lblCloudState
            // 
            this.lblCloudState.AutoSize = true;
            this.lblCloudState.Location = new System.Drawing.Point(979, 213);
            this.lblCloudState.Name = "lblCloudState";
            this.lblCloudState.Size = new System.Drawing.Size(51, 17);
            this.lblCloudState.TabIndex = 13;
            this.lblCloudState.Text = "Clouds";
            // 
            // btnShowCloud
            // 
            this.btnShowCloud.Location = new System.Drawing.Point(500, 226);
            this.btnShowCloud.Name = "btnShowCloud";
            this.btnShowCloud.Size = new System.Drawing.Size(141, 50);
            this.btnShowCloud.TabIndex = 14;
            this.btnShowCloud.Text = "Show";
            this.btnShowCloud.UseVisualStyleBackColor = true;
            this.btnShowCloud.Click += new System.EventHandler(this.btnShowCloud_Click);
            // 
            // dgvDays
            // 
            this.dgvDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDays.Location = new System.Drawing.Point(12, 296);
            this.dgvDays.Name = "dgvDays";
            this.dgvDays.RowHeadersWidth = 51;
            this.dgvDays.RowTemplate.Height = 24;
            this.dgvDays.Size = new System.Drawing.Size(1158, 158);
            this.dgvDays.TabIndex = 15;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(500, 460);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(141, 50);
            this.btnShowData.TabIndex = 16;
            this.btnShowData.Text = "Show";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(647, 17);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 17);
            this.lblCountry.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 558);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dgvDays);
            this.Controls.Add(this.btnShowCloud);
            this.Controls.Add(this.lblCloudState);
            this.Controls.Add(this.picCloud);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.txtWindSpdMph);
            this.Controls.Add(this.txtWindSpdKph);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblWindSpeedMph);
            this.Controls.Add(this.lblWindSpeedKph);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblCity);
            this.Name = "Form1";
            this.Text = "Weather API";
            ((System.ComponentModel.ISupportInitialize)(this.picCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWindSpeedKph;
        private System.Windows.Forms.Label lblWindSpeedMph;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtWindSpdKph;
        private System.Windows.Forms.TextBox txtWindSpdMph;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.PictureBox picCloud;
        private System.Windows.Forms.Button btnShowCloud;
        private System.Windows.Forms.DataGridView dgvDays;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCloudState;
    }
}

