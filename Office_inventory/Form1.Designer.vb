<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpenAdd = New System.Windows.Forms.Button()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlSidebar - dark blue left panel
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(26, 82, 143)
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(170, 450)
        Me.pnlSidebar.TabIndex = 6

        ' lblTitle
        Me.lblTitle.Text = "OFFICE" & vbCrLf & "INVENTORY"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Location = New System.Drawing.Point(0, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(170, 65)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' btnOpenAdd
        Me.btnOpenAdd.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.btnOpenAdd.ForeColor = System.Drawing.Color.White
        Me.btnOpenAdd.Font = New System.Drawing.Font("Segoe UI", 9.5, System.Drawing.FontStyle.Bold)
        Me.btnOpenAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenAdd.FlatAppearance.BorderSize = 0
        Me.btnOpenAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenAdd.Location = New System.Drawing.Point(10, 120)
        Me.btnOpenAdd.Name = "btnOpenAdd"
        Me.btnOpenAdd.Size = New System.Drawing.Size(150, 45)
        Me.btnOpenAdd.TabIndex = 1
        Me.btnOpenAdd.Text = "➕  Add New Item"
        Me.btnOpenAdd.UseVisualStyleBackColor = False

        ' btnEdit
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 9.5, System.Drawing.FontStyle.Bold)
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Location = New System.Drawing.Point(10, 180)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(150, 45)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "✏️  Edit Item"
        Me.btnEdit.UseVisualStyleBackColor = False

        ' btnDelete
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.5, System.Drawing.FontStyle.Bold)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(10, 240)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 45)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "🗑️  Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False

        ' dgvInventory
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(185, 50)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.RowTemplate.Height = 28
        Me.dgvInventory.Size = New System.Drawing.Size(837, 375)
        Me.dgvInventory.TabIndex = 2
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 82, 143)
        Me.dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvInventory.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5, System.Drawing.FontStyle.Bold)
        Me.dgvInventory.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvInventory.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30)
        Me.dgvInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(235, 242, 250)
        Me.dgvInventory.GridColor = System.Drawing.Color.FromArgb(200, 215, 230)
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.EnableHeadersVisualStyles = False

        ' lblID - hidden
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(185, 430)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(48, 16)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = ""
        Me.lblID.Visible = False

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(240, 244, 248)
        Me.ClientSize = New System.Drawing.Size(1040, 450)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.pnlSidebar)
        Me.pnlSidebar.Controls.Add(Me.lblTitle)
        Me.pnlSidebar.Controls.Add(Me.btnOpenAdd)
        Me.pnlSidebar.Controls.Add(Me.btnEdit)
        Me.pnlSidebar.Controls.Add(Me.btnDelete)
        Me.Name = "Form1"
        Me.Text = "Office Inventory System"
        Me.pnlSidebar.ResumeLayout(False)
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents btnOpenAdd As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblID As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlSidebar As Panel
End Class
