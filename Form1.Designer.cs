
namespace BD_P1
{
    partial class MoviesForm
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReleaseDateTo = new System.Windows.Forms.DateTimePicker();
            this.labelReleaseDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerReleaseDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labelReleaseDateFrom = new System.Windows.Forms.Label();
            this.textBoxRatingMax = new System.Windows.Forms.TextBox();
            this.labelRatingMax = new System.Windows.Forms.Label();
            this.textBoxRatingMin = new System.Windows.Forms.TextBox();
            this.labelRatingMin = new System.Windows.Forms.Label();
            this.checkBox3DImax = new System.Windows.Forms.CheckBox();
            this.label3DImax = new System.Windows.Forms.Label();
            this.textBoxBudgetMax = new System.Windows.Forms.TextBox();
            this.textBoxBudgetMin = new System.Windows.Forms.TextBox();
            this.labelBudgetMax = new System.Windows.Forms.Label();
            this.labelBudgetMin = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAvgRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3DImax = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColTicketsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.dateTimePickerReleaseDateTo);
            this.groupBoxSearch.Controls.Add(this.labelReleaseDateTo);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerReleaseDateFrom);
            this.groupBoxSearch.Controls.Add(this.labelReleaseDateFrom);
            this.groupBoxSearch.Controls.Add(this.textBoxRatingMax);
            this.groupBoxSearch.Controls.Add(this.labelRatingMax);
            this.groupBoxSearch.Controls.Add(this.textBoxRatingMin);
            this.groupBoxSearch.Controls.Add(this.labelRatingMin);
            this.groupBoxSearch.Controls.Add(this.checkBox3DImax);
            this.groupBoxSearch.Controls.Add(this.label3DImax);
            this.groupBoxSearch.Controls.Add(this.textBoxBudgetMax);
            this.groupBoxSearch.Controls.Add(this.textBoxBudgetMin);
            this.groupBoxSearch.Controls.Add(this.labelBudgetMax);
            this.groupBoxSearch.Controls.Add(this.labelBudgetMin);
            this.groupBoxSearch.Controls.Add(this.textBoxTitle);
            this.groupBoxSearch.Controls.Add(this.labelTitle);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 13);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(727, 150);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search options";
            // 
            // dateTimePickerReleaseDateTo
            // 
            this.dateTimePickerReleaseDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReleaseDateTo.Location = new System.Drawing.Point(444, 112);
            this.dateTimePickerReleaseDateTo.Name = "dateTimePickerReleaseDateTo";
            this.dateTimePickerReleaseDateTo.Size = new System.Drawing.Size(270, 27);
            this.dateTimePickerReleaseDateTo.TabIndex = 15;
            this.dateTimePickerReleaseDateTo.Value = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            // 
            // labelReleaseDateTo
            // 
            this.labelReleaseDateTo.AutoSize = true;
            this.labelReleaseDateTo.Location = new System.Drawing.Point(415, 117);
            this.labelReleaseDateTo.Name = "labelReleaseDateTo";
            this.labelReleaseDateTo.Size = new System.Drawing.Size(23, 20);
            this.labelReleaseDateTo.TabIndex = 14;
            this.labelReleaseDateTo.Text = "to";
            // 
            // dateTimePickerReleaseDateFrom
            // 
            this.dateTimePickerReleaseDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReleaseDateFrom.Location = new System.Drawing.Point(145, 112);
            this.dateTimePickerReleaseDateFrom.Name = "dateTimePickerReleaseDateFrom";
            this.dateTimePickerReleaseDateFrom.Size = new System.Drawing.Size(264, 27);
            this.dateTimePickerReleaseDateFrom.TabIndex = 13;
            this.dateTimePickerReleaseDateFrom.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // labelReleaseDateFrom
            // 
            this.labelReleaseDateFrom.AutoSize = true;
            this.labelReleaseDateFrom.Location = new System.Drawing.Point(7, 117);
            this.labelReleaseDateFrom.Name = "labelReleaseDateFrom";
            this.labelReleaseDateFrom.Size = new System.Drawing.Size(132, 20);
            this.labelReleaseDateFrom.TabIndex = 12;
            this.labelReleaseDateFrom.Text = "Release Date from";
            // 
            // textBoxRatingMax
            // 
            this.textBoxRatingMax.Location = new System.Drawing.Point(589, 66);
            this.textBoxRatingMax.Name = "textBoxRatingMax";
            this.textBoxRatingMax.Size = new System.Drawing.Size(125, 27);
            this.textBoxRatingMax.TabIndex = 11;
            // 
            // labelRatingMax
            // 
            this.labelRatingMax.AutoSize = true;
            this.labelRatingMax.Location = new System.Drawing.Point(546, 69);
            this.labelRatingMax.Name = "labelRatingMax";
            this.labelRatingMax.Size = new System.Drawing.Size(37, 20);
            this.labelRatingMax.TabIndex = 10;
            this.labelRatingMax.Text = "max";
            // 
            // textBoxRatingMin
            // 
            this.textBoxRatingMin.Location = new System.Drawing.Point(415, 66);
            this.textBoxRatingMin.Name = "textBoxRatingMin";
            this.textBoxRatingMin.Size = new System.Drawing.Size(125, 27);
            this.textBoxRatingMin.TabIndex = 9;
            // 
            // labelRatingMin
            // 
            this.labelRatingMin.AutoSize = true;
            this.labelRatingMin.Location = new System.Drawing.Point(325, 69);
            this.labelRatingMin.Name = "labelRatingMin";
            this.labelRatingMin.Size = new System.Drawing.Size(84, 20);
            this.labelRatingMin.TabIndex = 8;
            this.labelRatingMin.Text = "Rating: min";
            // 
            // checkBox3DImax
            // 
            this.checkBox3DImax.AutoSize = true;
            this.checkBox3DImax.Location = new System.Drawing.Point(92, 72);
            this.checkBox3DImax.Name = "checkBox3DImax";
            this.checkBox3DImax.Size = new System.Drawing.Size(18, 17);
            this.checkBox3DImax.TabIndex = 7;
            this.checkBox3DImax.UseVisualStyleBackColor = true;
            // 
            // label3DImax
            // 
            this.label3DImax.AutoSize = true;
            this.label3DImax.Location = new System.Drawing.Point(7, 69);
            this.label3DImax.Name = "label3DImax";
            this.label3DImax.Size = new System.Drawing.Size(64, 20);
            this.label3DImax.TabIndex = 6;
            this.label3DImax.Text = "3D Imax";
            // 
            // textBoxBudgetMax
            // 
            this.textBoxBudgetMax.Location = new System.Drawing.Point(589, 24);
            this.textBoxBudgetMax.Name = "textBoxBudgetMax";
            this.textBoxBudgetMax.Size = new System.Drawing.Size(125, 27);
            this.textBoxBudgetMax.TabIndex = 5;
            // 
            // textBoxBudgetMin
            // 
            this.textBoxBudgetMin.Location = new System.Drawing.Point(415, 24);
            this.textBoxBudgetMin.Name = "textBoxBudgetMin";
            this.textBoxBudgetMin.Size = new System.Drawing.Size(125, 27);
            this.textBoxBudgetMin.TabIndex = 4;
            // 
            // labelBudgetMax
            // 
            this.labelBudgetMax.AutoSize = true;
            this.labelBudgetMax.Location = new System.Drawing.Point(546, 27);
            this.labelBudgetMax.Name = "labelBudgetMax";
            this.labelBudgetMax.Size = new System.Drawing.Size(37, 20);
            this.labelBudgetMax.TabIndex = 3;
            this.labelBudgetMax.Text = "max";
            // 
            // labelBudgetMin
            // 
            this.labelBudgetMin.AutoSize = true;
            this.labelBudgetMin.Location = new System.Drawing.Point(320, 27);
            this.labelBudgetMin.Name = "labelBudgetMin";
            this.labelBudgetMin.Size = new System.Drawing.Size(89, 20);
            this.labelBudgetMin.TabIndex = 2;
            this.labelBudgetMin.Text = "Budget: min";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(74, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(240, 27);
            this.textBoxTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(7, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(746, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 110);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataTable
            // 
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTitle,
            this.ColReleaseDate,
            this.ColBudget,
            this.ColAvgRating,
            this.Col3DImax,
            this.ColTicketsSold});
            this.dataTable.Location = new System.Drawing.Point(13, 170);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersWidth = 51;
            this.dataTable.RowTemplate.Height = 29;
            this.dataTable.Size = new System.Drawing.Size(883, 188);
            this.dataTable.TabIndex = 2;
            this.dataTable.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_RowValidated);
            this.dataTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataTable_UserAddedRow);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Visible = false;
            this.ColId.Width = 125;
            // 
            // ColTitle
            // 
            this.ColTitle.HeaderText = "Title";
            this.ColTitle.MinimumWidth = 6;
            this.ColTitle.Name = "ColTitle";
            this.ColTitle.Width = 205;
            // 
            // ColReleaseDate
            // 
            this.ColReleaseDate.HeaderText = "ReleaseDate";
            this.ColReleaseDate.MinimumWidth = 6;
            this.ColReleaseDate.Name = "ColReleaseDate";
            this.ColReleaseDate.Width = 125;
            // 
            // ColBudget
            // 
            this.ColBudget.HeaderText = "Budget";
            this.ColBudget.MinimumWidth = 6;
            this.ColBudget.Name = "ColBudget";
            this.ColBudget.Width = 125;
            // 
            // ColAvgRating
            // 
            this.ColAvgRating.HeaderText = "Avg Rating";
            this.ColAvgRating.MinimumWidth = 6;
            this.ColAvgRating.Name = "ColAvgRating";
            this.ColAvgRating.Width = 125;
            // 
            // Col3DImax
            // 
            this.Col3DImax.HeaderText = "3D Imax";
            this.Col3DImax.MinimumWidth = 6;
            this.Col3DImax.Name = "Col3DImax";
            this.Col3DImax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Col3DImax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Col3DImax.Width = 125;
            // 
            // ColTicketsSold
            // 
            this.ColTicketsSold.HeaderText = "Tickets Sold";
            this.ColTicketsSold.MinimumWidth = 6;
            this.ColTicketsSold.Name = "ColTicketsSold";
            this.ColTicketsSold.Width = 125;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 559);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxSearch);
            this.KeyPreview = true;
            this.Name = "MoviesForm";
            this.Text = "MoviesForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoviesForm_KeyDown);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBudgetMin;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDateFrom;
        private System.Windows.Forms.Label labelReleaseDateFrom;
        private System.Windows.Forms.TextBox textBoxRatingMax;
        private System.Windows.Forms.Label labelRatingMax;
        private System.Windows.Forms.TextBox textBoxRatingMin;
        private System.Windows.Forms.Label labelRatingMin;
        private System.Windows.Forms.CheckBox checkBox3DImax;
        private System.Windows.Forms.Label label3DImax;
        private System.Windows.Forms.TextBox textBoxBudgetMax;
        private System.Windows.Forms.TextBox textBoxBudgetMin;
        private System.Windows.Forms.Label labelBudgetMax;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDateTo;
        private System.Windows.Forms.Label labelReleaseDateTo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAvgRating;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col3DImax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTicketsSold;
    }
}

