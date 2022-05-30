Public Class frmListino

    'Struttura dati
    Private Structure prodotto
        Dim nome As String
        Dim cognome As String
        Dim squadra As String
        Dim ruolo As String
    End Structure

    Dim Listino() As prodotto

    Dim i As Byte 'indice di scansione dell'array
    Dim indiceMax As Byte 'indice massimo dell'array

    Private Sub frmListino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnProcediCar.Enabled = True
        txtNumProdotti.Enabled = True
        grpProdotto.Enabled = False
        btnCarica.Enabled = False
        btnVisualizza.Enabled = False
        btnOrdina.Enabled = False
        grpOrdina.Enabled = False

        i = 0 'inizializza l'indice di scansione dell'array

    End Sub

    Private Sub btnProcediCar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProcediCar.Click

        indiceMax = Val(txtNumProdotti.Text) - 1  'inizializza l'indice massimo dell'array
        ReDim Listino(indiceMax) 'ridimensiona l'array a runtime 

        btnProcediCar.Enabled = False 'il bottone per avviare il caricamento ora è disabilitato
        txtNumProdotti.Enabled = False 'il numero di prodotti ora non deve poter essere modificato
        grpProdotto.Enabled = True 'le caselle di testo per i dati del prodotto ora sono abilitate
        btnCarica.Enabled = True 'il caricamento ora è abilitato

    End Sub

    Private Sub btnCarica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarica.Click
        'Input dei prodotti nel listino 
        With Listino(i)
            .nome = txt_nome.Text
            .cognome = txt_cognome.Text
            .ruolo = txt_ruolo.Text
            .squadra = txt_squadra.Text
        End With

        i = i + 1 'aggiorna l'indice di scansione dell'array

        'Se vettore pieno allora disabilita il bottone carica
        'altrimenti pulisce
        If i = Val(txtNumProdotti.Text) Then
            btnCarica.Enabled = False
            grpProdotto.Enabled = False
            btnVisualizza.Enabled = True
        Else
            txt_nome.Text = ""
            txt_cognome.Text = ""
            txt_ruolo.Text = ""
            txt_squadra.Text = ""     'torna sul primo textbox
            txt_nome.Focus()
        End If
    End Sub

    Sub VisualizzaArray()
        Dim indice As Byte
        lstListino.Items.Clear() 'svuota il listbox

        'nella finestra di progettazione si sceglie di impostare la proprietà font su "Courier New"
        'perchè in tale font ogni carattere ha la stessa larghezza e questo agevola la formattazione 
        lstListino.Items.Add("NOME".PadRight(15) & "COGNOME".PadRight(20) & "SQUADRA".PadRight(15) & "RUOLO".PadRight(15))
        lstListino.Items.Add("".PadRight(65, "-"))
        For indice = 0 To indiceMax
            With Listino(indice)
                lstListino.Items.Add(.nome.PadRight(15) &
                                     .cognome.PadRight(20) &
                                     .squadra.PadRight(15) &
                                     .ruolo.PadRight(15))
            End With
        Next indice

    End Sub

    Private Sub btnVisualizza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizza.Click

        btnVisualizza.Enabled = False 'il bottone per la visualizzazione ora è disabilitato
        btnOrdina.Enabled = True 'l'ordinamento ora è abilitato
        grpOrdina.Enabled = True 'ora si può scegliere il criterio di ordinamento
        rad_nominativo.Checked = True 'si imposta il criterio di ordinamento per codice per quello che
        'sarà il primo ordinamento, a meno di eventuali scelte scelte diverse da parte dell'utente

        VisualizzaArray()

    End Sub

    Sub scambio(ByRef x As Object, ByRef y As Object)
        Dim temp As Object
        temp = x
        x = y
        y = temp
    End Sub

    Sub OrdinaSelez()
        Dim i, j As Byte
        For i = 0 To indiceMax - 1
            For j = i + 1 To indiceMax

                If rad_nominativo.Checked = True Then
                    If Listino(i).nome.ToLower() > Listino(j).nome.ToLower() Then
                        scambio(Listino(i), Listino(j))
                    End If
                End If
                If rad_squadra.Checked = True Then
                    If Listino(i).squadra.ToLower() > Listino(j).squadra.ToLower() Then
                        scambio(Listino(i), Listino(j))
                    End If
                End If
                If rad_ruolo.Checked = True Then
                    If Listino(i).ruolo.ToLower() > Listino(j).ruolo.ToLower() Then
                        scambio(Listino(i), Listino(j))
                    End If
                End If
            Next j
        Next i
    End Sub

    Private Sub btnOrdina_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOrdina.Click
        OrdinaSelez()
        VisualizzaArray()
    End Sub

    Private Sub btnFine_Click(sender As Object, e As EventArgs) Handles btnFine.Click
        End
    End Sub
End Class
