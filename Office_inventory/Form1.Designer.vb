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
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpenAdd
        '
        Me.btnOpenAdd.Location = New System.Drawing.Point(12, 370)
        Me.btnOpenAdd.Name = "btnOpenAdd"
        Me.btnOpenAdd.Size = New System.Drawing.Size(120, 35)
        Me.btnOpenAdd.TabIndex = 1
        Me.btnOpenAdd.Text = "Add New Item"
        Me.btnOpenAdd.UseVisualStyleBackColor = True
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(257, 12)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.RowTemplate.Height = 24
        Me.dgvInventory.Size = New System.Drawing.Size(760, 340)
        Me.dgvInventory.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 450)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.btnOpenAdd)
        Me.Name = "Form1"
        Me.Text = "Office Inventory"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenAdd As Button
    Friend WithEvents dgvInventory As DataGridView

End Class