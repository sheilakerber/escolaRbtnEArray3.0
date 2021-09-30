Module modLimparCampos
    Public Sub limparCampos()
        mainForm.txtAluno.Text = Nothing
        mainForm.rbtDevSist.Checked = False
        mainForm.rbtEletrotec.Checked = False
        mainForm.rbtMecanica.Checked = False
        mainForm.cbxDisciplinas.Text = Nothing
    End Sub
End Module
