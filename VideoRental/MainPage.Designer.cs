namespace VideoRental
{
    partial class MainPage
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
            this.DateOfReturnDtp = new System.Windows.Forms.DateTimePicker();
            this.DateOfIssueDtp = new System.Windows.Forms.DateTimePicker();
            this.DeleteVideo = new System.Windows.Forms.Button();
            this.UpdateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopiesNm = new System.Windows.Forms.NumericUpDown();
            this.CostNm = new System.Windows.Forms.NumericUpDown();
            this.YearNm = new System.Windows.Forms.NumericUpDown();
            this.CustomerMobileNm = new System.Windows.Forms.NumericUpDown();
            this.GenreTxt = new System.Windows.Forms.TextBox();
            this.PlotTxt = new System.Windows.Forms.TextBox();
            this.RattingTxt = new System.Windows.Forms.TextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MovieIDTxt = new System.Windows.Forms.TextBox();
            this.CustIDTxt = new System.Windows.Forms.TextBox();
            this.DeleteBookVideo = new System.Windows.Forms.Button();
            this.ReturnVideo = new System.Windows.Forms.Button();
            this.IssueVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Delete_Customer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.CustAddressTxt = new System.Windows.Forms.TextBox();
            this.CustLastNameTxt = new System.Windows.Forms.TextBox();
            this.CustFirstNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.DataGridView();
            this.ListOfVideo = new System.Windows.Forms.Button();
            this.ListCustomer = new System.Windows.Forms.Button();
            this.ListOfRentals = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CopiesNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            this.SuspendLayout();
            // 
            // DateOfReturnDtp
            // 
            this.DateOfReturnDtp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfReturnDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfReturnDtp.Location = new System.Drawing.Point(1243, 254);
            this.DateOfReturnDtp.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfReturnDtp.Name = "DateOfReturnDtp";
            this.DateOfReturnDtp.Size = new System.Drawing.Size(204, 38);
            this.DateOfReturnDtp.TabIndex = 236;
            // 
            // DateOfIssueDtp
            // 
            this.DateOfIssueDtp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfIssueDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfIssueDtp.Location = new System.Drawing.Point(1243, 201);
            this.DateOfIssueDtp.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfIssueDtp.Name = "DateOfIssueDtp";
            this.DateOfIssueDtp.Size = new System.Drawing.Size(204, 38);
            this.DateOfIssueDtp.TabIndex = 235;
            this.DateOfIssueDtp.Value = new System.DateTime(2019, 7, 10, 0, 0, 0, 0);
            // 
            // DeleteVideo
            // 
            this.DeleteVideo.BackColor = System.Drawing.Color.Gray;
            this.DeleteVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteVideo.Location = new System.Drawing.Point(329, 438);
            this.DeleteVideo.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteVideo.Name = "DeleteVideo";
            this.DeleteVideo.Size = new System.Drawing.Size(145, 42);
            this.DeleteVideo.TabIndex = 234;
            this.DeleteVideo.Text = "Delete";
            this.DeleteVideo.UseVisualStyleBackColor = false;
            this.DeleteVideo.Click += new System.EventHandler(this.VideoDelete_Click);
            // 
            // UpdateVideo
            // 
            this.UpdateVideo.BackColor = System.Drawing.Color.Gray;
            this.UpdateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateVideo.Location = new System.Drawing.Point(186, 438);
            this.UpdateVideo.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateVideo.Name = "UpdateVideo";
            this.UpdateVideo.Size = new System.Drawing.Size(145, 42);
            this.UpdateVideo.TabIndex = 233;
            this.UpdateVideo.Text = "Update";
            this.UpdateVideo.UseVisualStyleBackColor = false;
            this.UpdateVideo.Click += new System.EventHandler(this.VideoUpdate_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.BackColor = System.Drawing.Color.Gray;
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(26, 438);
            this.AddVideo.Margin = new System.Windows.Forms.Padding(4);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(145, 42);
            this.AddVideo.TabIndex = 232;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = false;
            this.AddVideo.Click += new System.EventHandler(this.VideoAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1143, 53);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(237, 32);
            this.label18.TabIndex = 231;
            this.label18.Text = "Rental Framework";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(629, 53);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(276, 32);
            this.label17.TabIndex = 230;
            this.label17.Text = "Customer Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 229;
            this.label1.Text = "Video Information";
            // 
            // CopiesNm
            // 
            this.CopiesNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiesNm.Location = new System.Drawing.Point(215, 239);
            this.CopiesNm.Margin = new System.Windows.Forms.Padding(4);
            this.CopiesNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CopiesNm.Name = "CopiesNm";
            this.CopiesNm.Size = new System.Drawing.Size(205, 35);
            this.CopiesNm.TabIndex = 228;
            this.CopiesNm.ValueChanged += new System.EventHandler(this.CopiesNm_ValueChanged);
            // 
            // CostNm
            // 
            this.CostNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostNm.Location = new System.Drawing.Point(215, 283);
            this.CostNm.Margin = new System.Windows.Forms.Padding(4);
            this.CostNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CostNm.Name = "CostNm";
            this.CostNm.Size = new System.Drawing.Size(205, 35);
            this.CostNm.TabIndex = 227;
            // 
            // YearNm
            // 
            this.YearNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearNm.Location = new System.Drawing.Point(215, 196);
            this.YearNm.Margin = new System.Windows.Forms.Padding(4);
            this.YearNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.YearNm.Name = "YearNm";
            this.YearNm.Size = new System.Drawing.Size(205, 35);
            this.YearNm.TabIndex = 226;
            // 
            // CustomerMobileNm
            // 
            this.CustomerMobileNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerMobileNm.Location = new System.Drawing.Point(708, 197);
            this.CustomerMobileNm.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerMobileNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CustomerMobileNm.Name = "CustomerMobileNm";
            this.CustomerMobileNm.Size = new System.Drawing.Size(205, 35);
            this.CustomerMobileNm.TabIndex = 225;
            this.CustomerMobileNm.ValueChanged += new System.EventHandler(this.CustomerMobileNm_ValueChanged);
            // 
            // GenreTxt
            // 
            this.GenreTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTxt.Location = new System.Drawing.Point(215, 373);
            this.GenreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTxt.Name = "GenreTxt";
            this.GenreTxt.Size = new System.Drawing.Size(204, 38);
            this.GenreTxt.TabIndex = 224;
            // 
            // PlotTxt
            // 
            this.PlotTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotTxt.Location = new System.Drawing.Point(215, 326);
            this.PlotTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PlotTxt.Name = "PlotTxt";
            this.PlotTxt.Size = new System.Drawing.Size(204, 38);
            this.PlotTxt.TabIndex = 223;
            // 
            // RattingTxt
            // 
            this.RattingTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RattingTxt.Location = new System.Drawing.Point(215, 144);
            this.RattingTxt.Margin = new System.Windows.Forms.Padding(4);
            this.RattingTxt.Name = "RattingTxt";
            this.RattingTxt.Size = new System.Drawing.Size(204, 38);
            this.RattingTxt.TabIndex = 222;
            // 
            // TitleTxt
            // 
            this.TitleTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxt.Location = new System.Drawing.Point(215, 97);
            this.TitleTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(204, 38);
            this.TitleTxt.TabIndex = 221;
            this.TitleTxt.TextChanged += new System.EventHandler(this.TitleTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 384);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 220;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 219;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 218;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 217;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 216;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 215;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(81, 97);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 32);
            this.label16.TabIndex = 214;
            this.label16.Text = "Title";
            // 
            // MovieIDTxt
            // 
            this.MovieIDTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieIDTxt.Location = new System.Drawing.Point(1243, 151);
            this.MovieIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MovieIDTxt.Name = "MovieIDTxt";
            this.MovieIDTxt.Size = new System.Drawing.Size(204, 38);
            this.MovieIDTxt.TabIndex = 213;
            // 
            // CustIDTxt
            // 
            this.CustIDTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIDTxt.Location = new System.Drawing.Point(1243, 100);
            this.CustIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustIDTxt.Name = "CustIDTxt";
            this.CustIDTxt.Size = new System.Drawing.Size(204, 38);
            this.CustIDTxt.TabIndex = 212;
            // 
            // DeleteBookVideo
            // 
            this.DeleteBookVideo.BackColor = System.Drawing.Color.Gray;
            this.DeleteBookVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookVideo.Location = new System.Drawing.Point(1118, 396);
            this.DeleteBookVideo.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBookVideo.Name = "DeleteBookVideo";
            this.DeleteBookVideo.Size = new System.Drawing.Size(218, 46);
            this.DeleteBookVideo.TabIndex = 211;
            this.DeleteBookVideo.Text = "Delete";
            this.DeleteBookVideo.UseVisualStyleBackColor = false;
            this.DeleteBookVideo.Click += new System.EventHandler(this.DeleteBookVideo_Click);
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.BackColor = System.Drawing.Color.Gray;
            this.ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideo.Location = new System.Drawing.Point(1131, 345);
            this.ReturnVideo.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(188, 39);
            this.ReturnVideo.TabIndex = 210;
            this.ReturnVideo.Text = "Return";
            this.ReturnVideo.UseVisualStyleBackColor = false;
            this.ReturnVideo.Click += new System.EventHandler(this.ReturnVideo_Click);
            // 
            // IssueVideo
            // 
            this.IssueVideo.BackColor = System.Drawing.Color.Gray;
            this.IssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideo.Location = new System.Drawing.Point(1160, 300);
            this.IssueVideo.Margin = new System.Windows.Forms.Padding(4);
            this.IssueVideo.Name = "IssueVideo";
            this.IssueVideo.Size = new System.Drawing.Size(135, 39);
            this.IssueVideo.TabIndex = 209;
            this.IssueVideo.Text = "Issue";
            this.IssueVideo.UseVisualStyleBackColor = false;
            this.IssueVideo.Click += new System.EventHandler(this.BookVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1028, 251);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 32);
            this.label12.TabIndex = 208;
            this.label12.Text = "Date of Return ";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1028, 201);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 32);
            this.label13.TabIndex = 207;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1027, 154);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 32);
            this.label14.TabIndex = 206;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1027, 104);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 32);
            this.label15.TabIndex = 205;
            this.label15.Text = "Customer ID";
            // 
            // Delete_Customer
            // 
            this.Delete_Customer.BackColor = System.Drawing.Color.Gray;
            this.Delete_Customer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Customer.Location = new System.Drawing.Point(623, 396);
            this.Delete_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Customer.Name = "Delete_Customer";
            this.Delete_Customer.Size = new System.Drawing.Size(238, 46);
            this.Delete_Customer.TabIndex = 204;
            this.Delete_Customer.Text = "Delete";
            this.Delete_Customer.UseVisualStyleBackColor = false;
            this.Delete_Customer.Click += new System.EventHandler(this.Customer_Delete_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.Gray;
            this.UpdateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomer.Location = new System.Drawing.Point(659, 345);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(162, 39);
            this.UpdateCustomer.TabIndex = 203;
            this.UpdateCustomer.Text = "Update";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.CustomerUpdate_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.Gray;
            this.AddCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.Location = new System.Drawing.Point(670, 287);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(135, 39);
            this.AddCustomer.TabIndex = 201;
            this.AddCustomer.Text = "Add";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // CustAddressTxt
            // 
            this.CustAddressTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustAddressTxt.Location = new System.Drawing.Point(708, 241);
            this.CustAddressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustAddressTxt.Name = "CustAddressTxt";
            this.CustAddressTxt.Size = new System.Drawing.Size(204, 38);
            this.CustAddressTxt.TabIndex = 202;
            // 
            // CustLastNameTxt
            // 
            this.CustLastNameTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLastNameTxt.Location = new System.Drawing.Point(708, 148);
            this.CustLastNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustLastNameTxt.Name = "CustLastNameTxt";
            this.CustLastNameTxt.Size = new System.Drawing.Size(204, 38);
            this.CustLastNameTxt.TabIndex = 200;
            // 
            // CustFirstNameTxt
            // 
            this.CustFirstNameTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustFirstNameTxt.Location = new System.Drawing.Point(708, 101);
            this.CustFirstNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustFirstNameTxt.Name = "CustFirstNameTxt";
            this.CustFirstNameTxt.Size = new System.Drawing.Size(204, 38);
            this.CustFirstNameTxt.TabIndex = 199;
            this.CustFirstNameTxt.TextChanged += new System.EventHandler(this.CustFirstNameTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(540, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 198;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(540, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 197;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(540, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 32);
            this.label10.TabIndex = 196;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(540, 101);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 32);
            this.label11.TabIndex = 195;
            this.label11.Text = "First Name";
            // 
            // details
            // 
            this.details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.details.Location = new System.Drawing.Point(308, 502);
            this.details.Margin = new System.Windows.Forms.Padding(4);
            this.details.Name = "details";
            this.details.RowHeadersWidth = 51;
            this.details.Size = new System.Drawing.Size(814, 264);
            this.details.TabIndex = 237;
            this.details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.details_CellClick);
            this.details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Details_CellContentClick);
            // 
            // ListOfVideo
            // 
            this.ListOfVideo.BackColor = System.Drawing.Color.Gray;
            this.ListOfVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfVideo.Location = new System.Drawing.Point(1149, 535);
            this.ListOfVideo.Margin = new System.Windows.Forms.Padding(4);
            this.ListOfVideo.Name = "ListOfVideo";
            this.ListOfVideo.Size = new System.Drawing.Size(251, 42);
            this.ListOfVideo.TabIndex = 238;
            this.ListOfVideo.Text = "List of Video ";
            this.ListOfVideo.UseVisualStyleBackColor = false;
            this.ListOfVideo.Click += new System.EventHandler(this.VideoDetails_Click);
            // 
            // ListCustomer
            // 
            this.ListCustomer.BackColor = System.Drawing.Color.Gray;
            this.ListCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCustomer.Location = new System.Drawing.Point(38, 535);
            this.ListCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.ListCustomer.Name = "ListCustomer";
            this.ListCustomer.Size = new System.Drawing.Size(251, 42);
            this.ListCustomer.TabIndex = 239;
            this.ListCustomer.Text = "List of Customer";
            this.ListCustomer.UseVisualStyleBackColor = false;
            this.ListCustomer.Click += new System.EventHandler(this.customeretails_Click);
            // 
            // ListOfRentals
            // 
            this.ListOfRentals.BackColor = System.Drawing.Color.Gray;
            this.ListOfRentals.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOfRentals.Location = new System.Drawing.Point(38, 705);
            this.ListOfRentals.Margin = new System.Windows.Forms.Padding(4);
            this.ListOfRentals.Name = "ListOfRentals";
            this.ListOfRentals.Size = new System.Drawing.Size(251, 42);
            this.ListOfRentals.TabIndex = 240;
            this.ListOfRentals.Text = "List of Rentals";
            this.ListOfRentals.UseVisualStyleBackColor = false;
            this.ListOfRentals.Click += new System.EventHandler(this.RentalDetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial", 12.75F);
            this.button1.Location = new System.Drawing.Point(1149, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 42);
            this.button1.TabIndex = 241;
            this.button1.Text = "list of video Rating";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Arial", 12.2F);
            this.button2.Location = new System.Drawing.Point(38, 622);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 42);
            this.button2.TabIndex = 242;
            this.button2.Text = "List of Customer rating";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1478, 795);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListOfRentals);
            this.Controls.Add(this.ListCustomer);
            this.Controls.Add(this.ListOfVideo);
            this.Controls.Add(this.details);
            this.Controls.Add(this.DateOfReturnDtp);
            this.Controls.Add(this.DateOfIssueDtp);
            this.Controls.Add(this.DeleteVideo);
            this.Controls.Add(this.UpdateVideo);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopiesNm);
            this.Controls.Add(this.CostNm);
            this.Controls.Add(this.YearNm);
            this.Controls.Add(this.CustomerMobileNm);
            this.Controls.Add(this.GenreTxt);
            this.Controls.Add(this.PlotTxt);
            this.Controls.Add(this.RattingTxt);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.MovieIDTxt);
            this.Controls.Add(this.CustIDTxt);
            this.Controls.Add(this.DeleteBookVideo);
            this.Controls.Add(this.ReturnVideo);
            this.Controls.Add(this.IssueVideo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Delete_Customer);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.CustAddressTxt);
            this.Controls.Add(this.CustLastNameTxt);
            this.Controls.Add(this.CustFirstNameTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Text = "Pannel";
            ((System.ComponentModel.ISupportInitialize)(this.CopiesNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateOfReturnDtp;
        private System.Windows.Forms.DateTimePicker DateOfIssueDtp;
        private System.Windows.Forms.Button DeleteVideo;
        private System.Windows.Forms.Button UpdateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CopiesNm;
        private System.Windows.Forms.NumericUpDown CostNm;
        private System.Windows.Forms.NumericUpDown YearNm;
        private System.Windows.Forms.NumericUpDown CustomerMobileNm;
        private System.Windows.Forms.TextBox GenreTxt;
        private System.Windows.Forms.TextBox PlotTxt;
        private System.Windows.Forms.TextBox RattingTxt;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MovieIDTxt;
        private System.Windows.Forms.TextBox CustIDTxt;
        private System.Windows.Forms.Button DeleteBookVideo;
        private System.Windows.Forms.Button ReturnVideo;
        private System.Windows.Forms.Button IssueVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Delete_Customer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox CustAddressTxt;
        private System.Windows.Forms.TextBox CustLastNameTxt;
        private System.Windows.Forms.TextBox CustFirstNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView details;
        private System.Windows.Forms.Button ListOfVideo;
        private System.Windows.Forms.Button ListCustomer;
        private System.Windows.Forms.Button ListOfRentals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}