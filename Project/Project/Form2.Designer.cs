﻿namespace Project
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ertekelesekDataGridView = new System.Windows.Forms.DataGridView();
            this.TermekNevTextBox = new System.Windows.Forms.TextBox();
            this.csillagszamlbl = new System.Windows.Forms.Label();
            this.megjegyzeseklbl = new System.Windows.Forms.Label();
            this.MegjegyzesTextBox = new System.Windows.Forms.TextBox();
            this.ErtekelesAddButton = new System.Windows.Forms.Button();
            this.TermekListBox = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.osszesenlbl = new System.Windows.Forms.Label();
            this.atlaglbl = new System.Windows.Forms.Label();
            this.osszesentextbox = new System.Windows.Forms.TextBox();
            this.atlagtextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.csillagSzamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ertekelesSzamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ertekeloGomb1 = new Project.ErtekeloGomb();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.termekekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ertekelesekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ertekelesekDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ertekelesSzamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ertekelesekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.termekekBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(817, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ertekelesekDataGridView
            // 
            this.ertekelesekDataGridView.AutoGenerateColumns = false;
            this.ertekelesekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ertekelesekDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ertekelesekDataGridView.DataSource = this.ertekelesekBindingSource;
            this.ertekelesekDataGridView.Location = new System.Drawing.Point(6, 45);
            this.ertekelesekDataGridView.Name = "ertekelesekDataGridView";
            this.ertekelesekDataGridView.Size = new System.Drawing.Size(461, 220);
            this.ertekelesekDataGridView.TabIndex = 1;
            // 
            // TermekNevTextBox
            // 
            this.TermekNevTextBox.Location = new System.Drawing.Point(6, 299);
            this.TermekNevTextBox.Name = "TermekNevTextBox";
            this.TermekNevTextBox.Size = new System.Drawing.Size(160, 20);
            this.TermekNevTextBox.TabIndex = 4;
            this.TermekNevTextBox.TextChanged += new System.EventHandler(this.TermekNevTextBox_TextChanged);
            // 
            // csillagszamlbl
            // 
            this.csillagszamlbl.AutoSize = true;
            this.csillagszamlbl.Location = new System.Drawing.Point(173, 325);
            this.csillagszamlbl.Name = "csillagszamlbl";
            this.csillagszamlbl.Size = new System.Drawing.Size(85, 13);
            this.csillagszamlbl.TabIndex = 5;
            this.csillagszamlbl.Text = "Csillagok száma:";
            // 
            // megjegyzeseklbl
            // 
            this.megjegyzeseklbl.AutoSize = true;
            this.megjegyzeseklbl.Location = new System.Drawing.Point(173, 359);
            this.megjegyzeseklbl.Name = "megjegyzeseklbl";
            this.megjegyzeseklbl.Size = new System.Drawing.Size(78, 13);
            this.megjegyzeseklbl.TabIndex = 5;
            this.megjegyzeseklbl.Text = "Megjegyzések:";
            // 
            // MegjegyzesTextBox
            // 
            this.MegjegyzesTextBox.Location = new System.Drawing.Point(258, 359);
            this.MegjegyzesTextBox.Multiline = true;
            this.MegjegyzesTextBox.Name = "MegjegyzesTextBox";
            this.MegjegyzesTextBox.Size = new System.Drawing.Size(154, 135);
            this.MegjegyzesTextBox.TabIndex = 7;
            // 
            // ErtekelesAddButton
            // 
            this.ErtekelesAddButton.Location = new System.Drawing.Point(176, 500);
            this.ErtekelesAddButton.Name = "ErtekelesAddButton";
            this.ErtekelesAddButton.Size = new System.Drawing.Size(236, 50);
            this.ErtekelesAddButton.TabIndex = 8;
            this.ErtekelesAddButton.Text = "Értékelés elküldése";
            this.ErtekelesAddButton.UseVisualStyleBackColor = true;
            this.ErtekelesAddButton.Click += new System.EventHandler(this.ErtekelesAddButton_Click);
            // 
            // TermekListBox
            // 
            this.TermekListBox.FormattingEnabled = true;
            this.TermekListBox.Location = new System.Drawing.Point(6, 325);
            this.TermekListBox.Name = "TermekListBox";
            this.TermekListBox.Size = new System.Drawing.Size(160, 225);
            this.TermekListBox.TabIndex = 9;
            this.TermekListBox.SelectedIndexChanged += new System.EventHandler(this.TermekListBox_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.ertekelesSzamBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(487, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Gold;
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Értékelések";
            series1.XValueMember = "CsillagSzam";
            series1.YValueMembers = "Mennyiseg";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 220);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.csillagSzamDataGridViewTextBoxColumn,
            this.mennyisegDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ertekelesSzamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(487, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 191);
            this.dataGridView1.TabIndex = 11;
            // 
            // osszesenlbl
            // 
            this.osszesenlbl.AutoSize = true;
            this.osszesenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osszesenlbl.Location = new System.Drawing.Point(487, 272);
            this.osszesenlbl.Name = "osszesenlbl";
            this.osszesenlbl.Size = new System.Drawing.Size(120, 15);
            this.osszesenlbl.TabIndex = 12;
            this.osszesenlbl.Text = "Összes értékelés:";
            // 
            // atlaglbl
            // 
            this.atlaglbl.AutoSize = true;
            this.atlaglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.atlaglbl.Location = new System.Drawing.Point(684, 272);
            this.atlaglbl.Name = "atlaglbl";
            this.atlaglbl.Size = new System.Drawing.Size(43, 15);
            this.atlaglbl.TabIndex = 13;
            this.atlaglbl.Text = "Átlag:";
            // 
            // osszesentextbox
            // 
            this.osszesentextbox.Enabled = false;
            this.osszesentextbox.Location = new System.Drawing.Point(490, 299);
            this.osszesentextbox.Name = "osszesentextbox";
            this.osszesentextbox.Size = new System.Drawing.Size(100, 20);
            this.osszesentextbox.TabIndex = 14;
            // 
            // atlagtextbox
            // 
            this.atlagtextbox.Enabled = false;
            this.atlagtextbox.Location = new System.Drawing.Point(687, 299);
            this.atlagtextbox.Name = "atlagtextbox";
            this.atlagtextbox.Size = new System.Drawing.Size(100, 20);
            this.atlagtextbox.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(487, 556);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 88);
            this.textBox1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(487, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 599);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Az eszközhöz még nem küldtek be értékelést. Legyen ön az első!";
            // 
            // csillagSzamDataGridViewTextBoxColumn
            // 
            this.csillagSzamDataGridViewTextBoxColumn.DataPropertyName = "CsillagSzam";
            this.csillagSzamDataGridViewTextBoxColumn.HeaderText = "Csillag";
            this.csillagSzamDataGridViewTextBoxColumn.Name = "csillagSzamDataGridViewTextBoxColumn";
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiseg";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            // 
            // ertekelesSzamBindingSource
            // 
            this.ertekelesSzamBindingSource.DataSource = typeof(Project.ErtekelesSzam);
            // 
            // ertekeloGomb1
            // 
            this.ertekeloGomb1.BackColor = System.Drawing.Color.Yellow;
            this.ertekeloGomb1.CsillagValue = 5;
            this.ertekeloGomb1.Location = new System.Drawing.Point(323, 319);
            this.ertekeloGomb1.Name = "ertekeloGomb1";
            this.ertekeloGomb1.Size = new System.Drawing.Size(25, 25);
            this.ertekeloGomb1.TabIndex = 6;
            this.ertekeloGomb1.Text = "\r\n5";
            this.ertekeloGomb1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TermekFK";
            this.dataGridViewTextBoxColumn2.DataSource = this.termekekBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nev";
            this.dataGridViewTextBoxColumn2.HeaderText = "Név";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "TermekID";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // termekekBindingSource
            // 
            this.termekekBindingSource.DataSource = typeof(Project.Termekek);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Csillag";
            this.dataGridViewTextBoxColumn3.HeaderText = "Csillag";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Megjegyzesek";
            this.dataGridViewTextBoxColumn4.HeaderText = "Megjegyzések";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ertekelesekBindingSource
            // 
            this.ertekelesekBindingSource.DataSource = typeof(Project.Ertekelesek);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.atlagtextbox);
            this.Controls.Add(this.osszesentextbox);
            this.Controls.Add(this.atlaglbl);
            this.Controls.Add(this.osszesenlbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TermekListBox);
            this.Controls.Add(this.ErtekelesAddButton);
            this.Controls.Add(this.MegjegyzesTextBox);
            this.Controls.Add(this.ertekeloGomb1);
            this.Controls.Add(this.megjegyzeseklbl);
            this.Controls.Add(this.csillagszamlbl);
            this.Controls.Add(this.TermekNevTextBox);
            this.Controls.Add(this.ertekelesekDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ertekelesekDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ertekelesSzamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ertekelesekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource termekekBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource ertekelesekBindingSource;
        private System.Windows.Forms.DataGridView ertekelesekDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox TermekNevTextBox;
        private System.Windows.Forms.Label csillagszamlbl;
        private ErtekeloGomb ertekeloGomb1;
        private System.Windows.Forms.Label megjegyzeseklbl;
        private System.Windows.Forms.TextBox MegjegyzesTextBox;
        private System.Windows.Forms.Button ErtekelesAddButton;
        private System.Windows.Forms.ListBox TermekListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ertekelesSzamBindingSource;
        private System.Windows.Forms.Label osszesenlbl;
        private System.Windows.Forms.Label atlaglbl;
        private System.Windows.Forms.TextBox osszesentextbox;
        private System.Windows.Forms.TextBox atlagtextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn csillagSzamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}