<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAluno = New System.Windows.Forms.TextBox()
        Me.rbtDevSist = New System.Windows.Forms.RadioButton()
        Me.rbtMecanica = New System.Windows.Forms.RadioButton()
        Me.rbtEletrotec = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.cbxDisciplinas = New System.Windows.Forms.ComboBox()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.lsvAlunos = New System.Windows.Forms.ListView()
        Me.Aluno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Curso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Disciplina = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTotalAlunos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aluno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Curso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Disciplina:"
        '
        'txtAluno
        '
        Me.txtAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluno.Location = New System.Drawing.Point(97, 26)
        Me.txtAluno.Name = "txtAluno"
        Me.txtAluno.Size = New System.Drawing.Size(124, 24)
        Me.txtAluno.TabIndex = 3
        '
        'rbtDevSist
        '
        Me.rbtDevSist.AutoSize = True
        Me.rbtDevSist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDevSist.Location = New System.Drawing.Point(97, 78)
        Me.rbtDevSist.Name = "rbtDevSist"
        Me.rbtDevSist.Size = New System.Drawing.Size(113, 20)
        Me.rbtDevSist.TabIndex = 4
        Me.rbtDevSist.Text = "Dev. Sistemas"
        Me.rbtDevSist.UseVisualStyleBackColor = True
        '
        'rbtMecanica
        '
        Me.rbtMecanica.AutoSize = True
        Me.rbtMecanica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMecanica.Location = New System.Drawing.Point(97, 130)
        Me.rbtMecanica.Name = "rbtMecanica"
        Me.rbtMecanica.Size = New System.Drawing.Size(85, 20)
        Me.rbtMecanica.TabIndex = 5
        Me.rbtMecanica.Text = "Mecânica"
        Me.rbtMecanica.UseVisualStyleBackColor = True
        '
        'rbtEletrotec
        '
        Me.rbtEletrotec.AutoSize = True
        Me.rbtEletrotec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEletrotec.Location = New System.Drawing.Point(97, 104)
        Me.rbtEletrotec.Name = "rbtEletrotec"
        Me.rbtEletrotec.Size = New System.Drawing.Size(104, 20)
        Me.rbtEletrotec.TabIndex = 6
        Me.rbtEletrotec.Text = "Eletrotécnica"
        Me.rbtEletrotec.UseVisualStyleBackColor = True
        '
        'cbxDisciplinas
        '
        Me.cbxDisciplinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDisciplinas.FormattingEnabled = True
        Me.cbxDisciplinas.Location = New System.Drawing.Point(100, 178)
        Me.cbxDisciplinas.Name = "cbxDisciplinas"
        Me.cbxDisciplinas.Size = New System.Drawing.Size(121, 24)
        Me.cbxDisciplinas.TabIndex = 7
        '
        'btnMatricular
        '
        Me.btnMatricular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatricular.Location = New System.Drawing.Point(31, 219)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(190, 37)
        Me.btnMatricular.TabIndex = 8
        Me.btnMatricular.Text = "Matricular"
        Me.btnMatricular.UseVisualStyleBackColor = True
        '
        'lsvAlunos
        '
        Me.lsvAlunos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Aluno, Me.Curso, Me.Disciplina})
        Me.lsvAlunos.FullRowSelect = True
        Me.lsvAlunos.GridLines = True
        Me.lsvAlunos.Location = New System.Drawing.Point(242, 12)
        Me.lsvAlunos.Name = "lsvAlunos"
        Me.lsvAlunos.Size = New System.Drawing.Size(425, 178)
        Me.lsvAlunos.TabIndex = 9
        Me.lsvAlunos.UseCompatibleStateImageBehavior = False
        Me.lsvAlunos.View = System.Windows.Forms.View.Details
        '
        'Aluno
        '
        Me.Aluno.Text = "Aluno"
        Me.Aluno.Width = 140
        '
        'Curso
        '
        Me.Curso.Text = "Curso"
        Me.Curso.Width = 140
        '
        'Disciplina
        '
        Me.Disciplina.Text = "Disciplina"
        Me.Disciplina.Width = 140
        '
        'txtTotalAlunos
        '
        Me.txtTotalAlunos.AutoSize = True
        Me.txtTotalAlunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAlunos.Location = New System.Drawing.Point(402, 227)
        Me.txtTotalAlunos.Name = "txtTotalAlunos"
        Me.txtTotalAlunos.Size = New System.Drawing.Size(125, 18)
        Me.txtTotalAlunos.TabIndex = 10
        Me.txtTotalAlunos.Text = "Total de alunos: 0"
        Me.txtTotalAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 281)
        Me.Controls.Add(Me.txtTotalAlunos)
        Me.Controls.Add(Me.lsvAlunos)
        Me.Controls.Add(Me.btnMatricular)
        Me.Controls.Add(Me.cbxDisciplinas)
        Me.Controls.Add(Me.rbtEletrotec)
        Me.Controls.Add(Me.rbtMecanica)
        Me.Controls.Add(Me.rbtDevSist)
        Me.Controls.Add(Me.txtAluno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mainForm"
        Me.Text = "Escola 3.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAluno As System.Windows.Forms.TextBox
    Friend WithEvents rbtDevSist As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMecanica As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEletrotec As System.Windows.Forms.RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbxDisciplinas As System.Windows.Forms.ComboBox
    Friend WithEvents btnMatricular As System.Windows.Forms.Button
    Friend WithEvents lsvAlunos As System.Windows.Forms.ListView
    Friend WithEvents Aluno As System.Windows.Forms.ColumnHeader
    Friend WithEvents Curso As System.Windows.Forms.ColumnHeader
    Friend WithEvents Disciplina As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtTotalAlunos As System.Windows.Forms.Label

End Class
