Public Class mainForm
    ' matriz para armazenar os alunos
    Dim arrAlunos As New ArrayList

    ' variavel para verificar qual curso foi selecionado
    Public cursoChecked As String

    ' arrays para armazenar as disciplinas de cada curso
    Dim arrDiscpDesSist As Object = {"Lógica de Programãção", "Banco de Dados", "Programação Desktop", "Programação Web"}
    Dim arrDiscpEletrotec As Object = {"Cálculo", "Eletricidade", "Instalações Prediais", "Instalações Industriais"}
    Dim arrDiscpMecanica As Object = {"Cálculo", "Metrologia", "Resistência dos Materiais", "Manutenção Mecânica"}

    ' atualiza o combobox com as disciplinas do curso Dev. Sistemas
    Private Sub rbtDevSist_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDevSist.CheckedChanged
        If (rbtDevSist.Checked) Then
            cbxDisciplinas.DataSource = arrDiscpDesSist
            cursoChecked = "Dev. Sistemas"
        End If
    End Sub

    ' atualiza o combobox com as disciplinas do curso Eletrotecnica
    Private Sub rbtEletrotec_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEletrotec.CheckedChanged
        If (rbtEletrotec.Checked) Then
            cbxDisciplinas.DataSource = arrDiscpEletrotec
            cursoChecked = "Eletrotécnica"
        End If
    End Sub

    ' atualiza o combobox com as disciplinas do curso Mecanica
    Private Sub rbtMecanica_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMecanica.CheckedChanged
        If (rbtMecanica.Checked) Then
            cbxDisciplinas.DataSource = arrDiscpMecanica
            cursoChecked = "Mecânica"
        End If
    End Sub

    ' ao clicar no botao "Matricular" ...
    Private Sub btnMatricular_Click(sender As Object, e As EventArgs) Handles btnMatricular.Click

        ' chama a funcao de validação dos campos utilizando o modValidarCampos
        modValidarCampos.validarcampos(txtAluno.Text)

        ' limpar listview antes de atualizar dados
        lsvAlunos.Clear()

        ' recria colunas
        lsvAlunos.Columns.Add("Aluno")
        lsvAlunos.Columns.Add("Curso")
        lsvAlunos.Columns.Add("Disciplina")

        ' add as informacoes do aluno no array
        arrAlunos.Add({txtAluno.Text, cursoChecked, cbxDisciplinas.SelectedValue})

        ' chama o procedimento para limpar os campos utilizando o modLimparCampos
        modLimparCampos.limparCampos()

        ' exibe na listview
        For Each linha As Object In arrAlunos
            Dim lvItem As ListViewItem = lsvAlunos.Items.Add(linha(0))
            lvItem.SubItems.Add(linha(1))
            lvItem.SubItems.Add(linha(2))
        Next

        ' formata a largura das colunas
        lsvAlunos.Columns(0).Width = 140
        lsvAlunos.Columns(1).Width = 140
        lsvAlunos.Columns(2).Width = 140

        ' atualiza o total de alunos cadastrados no sistema
        txtTotalAlunos.Text = "Total de alunos: " & arrAlunos.Count
    End Sub
End Class
