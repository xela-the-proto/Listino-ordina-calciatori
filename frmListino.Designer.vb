<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListino
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOrdina = New System.Windows.Forms.Button()
        Me.grpOrdina = New System.Windows.Forms.GroupBox()
        Me.rad_nominativo = New System.Windows.Forms.RadioButton()
        Me.rad_ruolo = New System.Windows.Forms.RadioButton()
        Me.rad_squadra = New System.Windows.Forms.RadioButton()
        Me.btnProcediCar = New System.Windows.Forms.Button()
        Me.txtNumProdotti = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstListino = New System.Windows.Forms.ListBox()
        Me.btnVisualizza = New System.Windows.Forms.Button()
        Me.btnFine = New System.Windows.Forms.Button()
        Me.btnCarica = New System.Windows.Forms.Button()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_cognome = New System.Windows.Forms.TextBox()
        Me.txt_squadra = New System.Windows.Forms.TextBox()
        Me.grpProdotto = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ruolo = New System.Windows.Forms.TextBox()
        Me.grpOrdina.SuspendLayout()
        Me.grpProdotto.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOrdina
        '
        Me.btnOrdina.Location = New System.Drawing.Point(441, 248)
        Me.btnOrdina.Name = "btnOrdina"
        Me.btnOrdina.Size = New System.Drawing.Size(58, 22)
        Me.btnOrdina.TabIndex = 26
        Me.btnOrdina.Text = "Ordina"
        Me.btnOrdina.UseVisualStyleBackColor = True
        '
        'grpOrdina
        '
        Me.grpOrdina.Controls.Add(Me.rad_nominativo)
        Me.grpOrdina.Controls.Add(Me.rad_ruolo)
        Me.grpOrdina.Controls.Add(Me.rad_squadra)
        Me.grpOrdina.Location = New System.Drawing.Point(441, 276)
        Me.grpOrdina.Name = "grpOrdina"
        Me.grpOrdina.Size = New System.Drawing.Size(144, 111)
        Me.grpOrdina.TabIndex = 25
        Me.grpOrdina.TabStop = False
        Me.grpOrdina.Text = "criterio di ordinamento"
        '
        'rad_nominativo
        '
        Me.rad_nominativo.AutoSize = True
        Me.rad_nominativo.Location = New System.Drawing.Point(30, 31)
        Me.rad_nominativo.Name = "rad_nominativo"
        Me.rad_nominativo.Size = New System.Drawing.Size(78, 17)
        Me.rad_nominativo.TabIndex = 12
        Me.rad_nominativo.TabStop = True
        Me.rad_nominativo.Text = "Nominativo"
        Me.rad_nominativo.UseVisualStyleBackColor = True
        '
        'rad_ruolo
        '
        Me.rad_ruolo.AutoSize = True
        Me.rad_ruolo.Location = New System.Drawing.Point(30, 77)
        Me.rad_ruolo.Name = "rad_ruolo"
        Me.rad_ruolo.Size = New System.Drawing.Size(53, 17)
        Me.rad_ruolo.TabIndex = 14
        Me.rad_ruolo.TabStop = True
        Me.rad_ruolo.Text = "Ruolo"
        Me.rad_ruolo.UseVisualStyleBackColor = True
        '
        'rad_squadra
        '
        Me.rad_squadra.AutoSize = True
        Me.rad_squadra.Location = New System.Drawing.Point(30, 54)
        Me.rad_squadra.Name = "rad_squadra"
        Me.rad_squadra.Size = New System.Drawing.Size(65, 17)
        Me.rad_squadra.TabIndex = 13
        Me.rad_squadra.TabStop = True
        Me.rad_squadra.Text = "Squadra"
        Me.rad_squadra.UseVisualStyleBackColor = True
        '
        'btnProcediCar
        '
        Me.btnProcediCar.Location = New System.Drawing.Point(60, 55)
        Me.btnProcediCar.Name = "btnProcediCar"
        Me.btnProcediCar.Size = New System.Drawing.Size(158, 25)
        Me.btnProcediCar.TabIndex = 24
        Me.btnProcediCar.Text = "&Procedi con il caricamento"
        Me.btnProcediCar.UseVisualStyleBackColor = True
        '
        'txtNumProdotti
        '
        Me.txtNumProdotti.Location = New System.Drawing.Point(221, 24)
        Me.txtNumProdotti.Name = "txtNumProdotti"
        Me.txtNumProdotti.Size = New System.Drawing.Size(58, 20)
        Me.txtNumProdotti.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Numero di giocatori da caricare"
        '
        'lstListino
        '
        Me.lstListino.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstListino.FormattingEnabled = True
        Me.lstListino.ItemHeight = 14
        Me.lstListino.Location = New System.Drawing.Point(346, 55)
        Me.lstListino.Name = "lstListino"
        Me.lstListino.Size = New System.Drawing.Size(392, 158)
        Me.lstListino.TabIndex = 21
        '
        'btnVisualizza
        '
        Me.btnVisualizza.Location = New System.Drawing.Point(346, 25)
        Me.btnVisualizza.Name = "btnVisualizza"
        Me.btnVisualizza.Size = New System.Drawing.Size(70, 24)
        Me.btnVisualizza.TabIndex = 20
        Me.btnVisualizza.Text = "&Visualizza"
        Me.btnVisualizza.UseVisualStyleBackColor = True
        '
        'btnFine
        '
        Me.btnFine.Location = New System.Drawing.Point(693, 423)
        Me.btnFine.Name = "btnFine"
        Me.btnFine.Size = New System.Drawing.Size(45, 23)
        Me.btnFine.TabIndex = 18
        Me.btnFine.Text = "&Fine"
        Me.btnFine.UseVisualStyleBackColor = True
        '
        'btnCarica
        '
        Me.btnCarica.Location = New System.Drawing.Point(60, 300)
        Me.btnCarica.Name = "btnCarica"
        Me.btnCarica.Size = New System.Drawing.Size(52, 24)
        Me.btnCarica.TabIndex = 17
        Me.btnCarica.Text = "&Carica"
        Me.btnCarica.UseVisualStyleBackColor = True
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(103, 32)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(77, 20)
        Me.txt_nome.TabIndex = 7
        '
        'txt_cognome
        '
        Me.txt_cognome.Location = New System.Drawing.Point(103, 58)
        Me.txt_cognome.Name = "txt_cognome"
        Me.txt_cognome.Size = New System.Drawing.Size(140, 20)
        Me.txt_cognome.TabIndex = 8
        '
        'txt_squadra
        '
        Me.txt_squadra.Location = New System.Drawing.Point(103, 84)
        Me.txt_squadra.Name = "txt_squadra"
        Me.txt_squadra.Size = New System.Drawing.Size(77, 20)
        Me.txt_squadra.TabIndex = 9
        '
        'grpProdotto
        '
        Me.grpProdotto.Controls.Add(Me.Label5)
        Me.grpProdotto.Controls.Add(Me.Label3)
        Me.grpProdotto.Controls.Add(Me.Label2)
        Me.grpProdotto.Controls.Add(Me.Label1)
        Me.grpProdotto.Controls.Add(Me.txt_ruolo)
        Me.grpProdotto.Controls.Add(Me.txt_squadra)
        Me.grpProdotto.Controls.Add(Me.txt_cognome)
        Me.grpProdotto.Controls.Add(Me.txt_nome)
        Me.grpProdotto.Location = New System.Drawing.Point(60, 139)
        Me.grpProdotto.Name = "grpProdotto"
        Me.grpProdotto.Size = New System.Drawing.Size(259, 155)
        Me.grpProdotto.TabIndex = 19
        Me.grpProdotto.TabStop = False
        Me.grpProdotto.Text = "Dati del prodotto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ruolo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Squadra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cognome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome"
        '
        'txt_ruolo
        '
        Me.txt_ruolo.Location = New System.Drawing.Point(103, 114)
        Me.txt_ruolo.Name = "txt_ruolo"
        Me.txt_ruolo.Size = New System.Drawing.Size(100, 20)
        Me.txt_ruolo.TabIndex = 10
        '
        'frmListino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 478)
        Me.Controls.Add(Me.btnOrdina)
        Me.Controls.Add(Me.grpOrdina)
        Me.Controls.Add(Me.btnProcediCar)
        Me.Controls.Add(Me.txtNumProdotti)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstListino)
        Me.Controls.Add(Me.btnVisualizza)
        Me.Controls.Add(Me.grpProdotto)
        Me.Controls.Add(Me.btnFine)
        Me.Controls.Add(Me.btnCarica)
        Me.Name = "frmListino"
        Me.Text = "GESTIONE PRODOTTI"
        Me.grpOrdina.ResumeLayout(False)
        Me.grpOrdina.PerformLayout()
        Me.grpProdotto.ResumeLayout(False)
        Me.grpProdotto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOrdina As System.Windows.Forms.Button
    Friend WithEvents grpOrdina As System.Windows.Forms.GroupBox
    Friend WithEvents rad_nominativo As System.Windows.Forms.RadioButton
    Friend WithEvents rad_ruolo As System.Windows.Forms.RadioButton
    Friend WithEvents rad_squadra As System.Windows.Forms.RadioButton
    Friend WithEvents btnProcediCar As System.Windows.Forms.Button
    Friend WithEvents txtNumProdotti As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstListino As System.Windows.Forms.ListBox
    Friend WithEvents btnVisualizza As System.Windows.Forms.Button
    Friend WithEvents btnFine As System.Windows.Forms.Button
    Friend WithEvents btnCarica As System.Windows.Forms.Button
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_cognome As TextBox
    Friend WithEvents txt_squadra As TextBox
    Friend WithEvents grpProdotto As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ruolo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
