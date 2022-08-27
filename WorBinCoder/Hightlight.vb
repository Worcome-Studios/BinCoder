Public Class Hightlight

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Enabled = True
        TextBox2.ReadOnly = False
        BuscarTexto(TextEditor.RichTextBox1)
    End Sub
    Private Sub BuscarTexto(ByVal RichTextBox As Object, Optional ByVal PosIni As Integer = 0)

        Dim Pos As Integer
        Dim PalabraClave As String
        Dim TipoBusqueda As Long

        PalabraClave = TextBox1.Text

        If Len(PalabraClave) Then

            'Busca desde la PosIni que se indico...
            Pos = InStr(PosIni + 1, RichTextBox.Text, PalabraClave, TipoBusqueda)
            If Pos > 0 Then

                With RichTextBox
                    TextEditor.RichTextBox1.SelectionStart = Pos - 1
                    TextEditor.RichTextBox1.SelectionLength = Len(PalabraClave)
                    TextEditor.RichTextBox1.Focus()
                End With
                Me.Text = "Se encontro la palabra."
            Else

                TextEditor.RichTextBox1.Focus()
                Me.Text = "No se encontro."
            End If
        End If

    End Sub

    ' reemplazar el texto seleccionado

    Private Sub RemplazarTexto(ByVal RichTextBox As Object, Optional ByVal PosIni As Integer = 0)


        Dim Pos As Integer
        Dim PalabraClave As String

        'TipoBusqueda corresponde si se busca Mayus y Minus identicas...
        Dim TipoBusqueda As Long

        'La variable PalabraClave toma el valor de txt_Buscar
        PalabraClave = TextBox1.Text

        'Verificar si PalabraClave no esta vacia
        If Len(PalabraClave) Then
            'Busca desde la PosIni que se indico..
            Pos = InStr(PosIni + 1, RichTextBox.Text, PalabraClave, TipoBusqueda)
            If Pos > 0 Then
                'Si devolvio mayor de 0...se encontro
                TextEditor.RichTextBox1.SelectionStart = Pos - 1
                TextEditor.RichTextBox1.SelectionLength = Len(PalabraClave)
                TextEditor.RichTextBox1.Focus()

                'Eliminamos el contenido del clipboard
                Clipboard.Clear()
                Clipboard.SetText(TextBox2.Text)
                'Pega el contenido
                SendKeys.Send("^(V)")

                Me.Text = "Se encontro y reemplazo la cadena de texto."
            Else
                'No se encontró
                TextEditor.RichTextBox1.Focus()
                Me.Text = "No se encontro."
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RemplazarTexto(TextEditor.RichTextBox1)
    End Sub

    Private Sub Hightlight_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Dim index As Integer = 0
        Dim temp As String = TextEditor.RichTextBox1.Text
        TextEditor.RichTextBox1.Text = ""
        TextEditor.RichTextBox1.Text = temp
    End Sub

    Private Sub Hightlight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class