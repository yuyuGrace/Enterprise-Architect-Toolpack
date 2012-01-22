﻿/*
 * Created by SharpDevelop.
 * User: wij
 * Date: 22/01/2012
 * Time: 13:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EAWorksetSharing
{
	partial class WorkingSetSharingWindow
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.allWorkingSetsButton = new System.Windows.Forms.Button();
			this.nonWorkingSetsButton = new System.Windows.Forms.Button();
			this.MyWorkingSetsButton = new System.Windows.Forms.Button();
			this.meUserButton = new System.Windows.Forms.Button();
			this.nonUsersButton = new System.Windows.Forms.Button();
			this.allUsersButton = new System.Windows.Forms.Button();
			this.WorkingSetsList = new System.Windows.Forms.ListView();
			this.workingSetHeader = new System.Windows.Forms.ColumnHeader();
			this.loginHeader = new System.Windows.Forms.ColumnHeader();
			this.firstNameHeader = new System.Windows.Forms.ColumnHeader();
			this.lastNameHeader = new System.Windows.Forms.ColumnHeader();
			this.userList = new System.Windows.Forms.ListView();
			this.userLoginHeader = new System.Windows.Forms.ColumnHeader();
			this.userFirstNameHeader = new System.Windows.Forms.ColumnHeader();
			this.userLastNameHeader = new System.Windows.Forms.ColumnHeader();
			this.cancelButton = new System.Windows.Forms.Button();
			this.copyButton = new System.Windows.Forms.Button();
			this.overWriteCheck = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// allWorkingSetsButton
			// 
			this.allWorkingSetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.allWorkingSetsButton.Location = new System.Drawing.Point(12, 413);
			this.allWorkingSetsButton.Name = "allWorkingSetsButton";
			this.allWorkingSetsButton.Size = new System.Drawing.Size(42, 22);
			this.allWorkingSetsButton.TabIndex = 1;
			this.allWorkingSetsButton.Text = "All";
			this.allWorkingSetsButton.UseVisualStyleBackColor = true;
			this.allWorkingSetsButton.Click += new System.EventHandler(this.AllWorkingSetsButtonClick);
			// 
			// nonWorkingSetsButton
			// 
			this.nonWorkingSetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.nonWorkingSetsButton.Location = new System.Drawing.Point(60, 413);
			this.nonWorkingSetsButton.Name = "nonWorkingSetsButton";
			this.nonWorkingSetsButton.Size = new System.Drawing.Size(45, 22);
			this.nonWorkingSetsButton.TabIndex = 2;
			this.nonWorkingSetsButton.Text = "None";
			this.nonWorkingSetsButton.UseVisualStyleBackColor = true;
			this.nonWorkingSetsButton.Click += new System.EventHandler(this.NonWorkingSetsButtonClick);
			// 
			// MyWorkingSetsButton
			// 
			this.MyWorkingSetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.MyWorkingSetsButton.Location = new System.Drawing.Point(111, 413);
			this.MyWorkingSetsButton.Name = "MyWorkingSetsButton";
			this.MyWorkingSetsButton.Size = new System.Drawing.Size(106, 22);
			this.MyWorkingSetsButton.TabIndex = 3;
			this.MyWorkingSetsButton.Text = "My Working Sets";
			this.MyWorkingSetsButton.UseVisualStyleBackColor = true;
			this.MyWorkingSetsButton.Click += new System.EventHandler(this.MyWorkingSetsButtonClick);
			// 
			// meUserButton
			// 
			this.meUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.meUserButton.Location = new System.Drawing.Point(522, 413);
			this.meUserButton.Name = "meUserButton";
			this.meUserButton.Size = new System.Drawing.Size(39, 22);
			this.meUserButton.TabIndex = 7;
			this.meUserButton.Text = "Me";
			this.meUserButton.UseVisualStyleBackColor = true;
			this.meUserButton.Click += new System.EventHandler(this.MeUserButtonClick);
			// 
			// nonUsersButton
			// 
			this.nonUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.nonUsersButton.Location = new System.Drawing.Point(471, 413);
			this.nonUsersButton.Name = "nonUsersButton";
			this.nonUsersButton.Size = new System.Drawing.Size(45, 22);
			this.nonUsersButton.TabIndex = 6;
			this.nonUsersButton.Text = "None";
			this.nonUsersButton.UseVisualStyleBackColor = true;
			this.nonUsersButton.Click += new System.EventHandler(this.NonUsersButtonClick);
			// 
			// allUsersButton
			// 
			this.allUsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.allUsersButton.Location = new System.Drawing.Point(423, 413);
			this.allUsersButton.Name = "allUsersButton";
			this.allUsersButton.Size = new System.Drawing.Size(42, 22);
			this.allUsersButton.TabIndex = 5;
			this.allUsersButton.Text = "All";
			this.allUsersButton.UseVisualStyleBackColor = true;
			this.allUsersButton.Click += new System.EventHandler(this.AllUsersButtonClick);
			// 
			// WorkingSetsList
			// 
			this.WorkingSetsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.WorkingSetsList.CheckBoxes = true;
			this.WorkingSetsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.workingSetHeader,
									this.loginHeader,
									this.firstNameHeader,
									this.lastNameHeader});
			this.WorkingSetsList.Location = new System.Drawing.Point(12, 12);
			this.WorkingSetsList.Name = "WorkingSetsList";
			this.WorkingSetsList.Size = new System.Drawing.Size(405, 395);
			this.WorkingSetsList.TabIndex = 0;
			this.WorkingSetsList.UseCompatibleStateImageBehavior = false;
			this.WorkingSetsList.View = System.Windows.Forms.View.Details;
			// 
			// workingSetHeader
			// 
			this.workingSetHeader.Text = "Working Set";
			this.workingSetHeader.Width = 145;
			// 
			// loginHeader
			// 
			this.loginHeader.Text = "Login";
			// 
			// firstNameHeader
			// 
			this.firstNameHeader.Text = "First Name";
			this.firstNameHeader.Width = 80;
			// 
			// lastNameHeader
			// 
			this.lastNameHeader.Text = "Last Name";
			this.lastNameHeader.Width = 107;
			// 
			// userList
			// 
			this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.userList.CheckBoxes = true;
			this.userList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.userLoginHeader,
									this.userFirstNameHeader,
									this.userLastNameHeader});
			this.userList.Location = new System.Drawing.Point(423, 12);
			this.userList.Name = "userList";
			this.userList.Size = new System.Drawing.Size(351, 395);
			this.userList.TabIndex = 4;
			this.userList.UseCompatibleStateImageBehavior = false;
			this.userList.View = System.Windows.Forms.View.Details;
			// 
			// userLoginHeader
			// 
			this.userLoginHeader.Text = "Login";
			// 
			// userFirstNameHeader
			// 
			this.userFirstNameHeader.Text = "First Name";
			this.userFirstNameHeader.Width = 100;
			// 
			// userLastNameHeader
			// 
			this.userLastNameHeader.Text = "Last Name";
			this.userLastNameHeader.Width = 183;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(699, 444);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// copyButton
			// 
			this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.copyButton.Location = new System.Drawing.Point(618, 444);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(75, 23);
			this.copyButton.TabIndex = 9;
			this.copyButton.Text = "Copy";
			this.copyButton.UseVisualStyleBackColor = true;
			this.copyButton.Click += new System.EventHandler(this.CopyButtonClick);
			// 
			// overWriteCheck
			// 
			this.overWriteCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.overWriteCheck.Enabled = false;
			this.overWriteCheck.Location = new System.Drawing.Point(529, 444);
			this.overWriteCheck.Name = "overWriteCheck";
			this.overWriteCheck.Size = new System.Drawing.Size(83, 24);
			this.overWriteCheck.TabIndex = 8;
			this.overWriteCheck.Text = "Overwrite";
			this.overWriteCheck.UseVisualStyleBackColor = true;
			// 
			// WorkingSetSharingWindow
			// 
			this.AcceptButton = this.copyButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(782, 476);
			this.Controls.Add(this.overWriteCheck);
			this.Controls.Add(this.copyButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.userList);
			this.Controls.Add(this.WorkingSetsList);
			this.Controls.Add(this.meUserButton);
			this.Controls.Add(this.nonUsersButton);
			this.Controls.Add(this.allUsersButton);
			this.Controls.Add(this.MyWorkingSetsButton);
			this.Controls.Add(this.nonWorkingSetsButton);
			this.Controls.Add(this.allWorkingSetsButton);
			this.MinimumSize = new System.Drawing.Size(798, 514);
			this.Name = "WorkingSetSharingWindow";
			this.Text = "Copy Working Sets";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox overWriteCheck;
		private System.Windows.Forms.Button copyButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ListView userList;
		private System.Windows.Forms.ColumnHeader userLastNameHeader;
		private System.Windows.Forms.ColumnHeader userFirstNameHeader;
		private System.Windows.Forms.ColumnHeader userLoginHeader;
		private System.Windows.Forms.ColumnHeader lastNameHeader;
		private System.Windows.Forms.ColumnHeader firstNameHeader;
		private System.Windows.Forms.ColumnHeader loginHeader;
		private System.Windows.Forms.ColumnHeader workingSetHeader;
		private System.Windows.Forms.ListView WorkingSetsList;
		private System.Windows.Forms.Button allUsersButton;
		private System.Windows.Forms.Button nonUsersButton;
		private System.Windows.Forms.Button meUserButton;
		private System.Windows.Forms.Button MyWorkingSetsButton;
		private System.Windows.Forms.Button nonWorkingSetsButton;
		private System.Windows.Forms.Button allWorkingSetsButton;
	}
}
