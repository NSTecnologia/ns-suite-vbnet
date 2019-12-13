Namespace src.JSON.MDFe

    Public Class InfMunCarrega
        Public Property cMunCarrega As String
        Public Property xMunCarrega As String
    End Class

    Public Class InfPercurso
        Public Property UFPer As String
    End Class

    Public Class Ide
        Public Property cUF As String
        Public Property tpAmb As String
        Public Property tpEmit As String
        Public Property tpTransp As String
        Public Property [mod] As String
        Public Property serie As String
        Public Property nMDF As String
        Public Property cMDF As String
        Public Property cDV As String
        Public Property modal As String
        Public Property dhEmi As String
        Public Property tpEmis As String
        Public Property procEmi As String
        Public Property verProc As String
        Public Property UFIni As String
        Public Property UFFim As String
        Public Property infMunCarrega As InfMunCarrega()
        Public Property infPercurso As InfPercurso()
        Public Property dhIniViagem As String
    End Class

    Public Class EnderEmit
        Public Property xLgr As String
        Public Property nro As String
        Public Property xCpl As String
        Public Property xBairro As String
        Public Property cMun As String
        Public Property xMun As String
        Public Property CEP As String
        Public Property UF As String
        Public Property fone As String
        Public Property email As String
    End Class

    Public Class Emit
        Public Property CNPJ As String
        Public Property IE As String
        Public Property xNome As String
        Public Property xFant As String
        Public Property enderEmit As EnderEmit
    End Class

    Public Class LacUnidTransp
        Public Property nLacre As String
    End Class

    Public Class LacUnidCarga
        Public Property nLacre As String
    End Class

    Public Class InfUnidCarga
        Public Property tpUnidCarga As String
        Public Property idUnidCarga As String
        Public Property lacUnidCarga As LacUnidCarga()
        Public Property qtdRat As String
    End Class

    Public Class InfUnidTransp
        Public Property tpUnidTransp As String
        Public Property idUnidTransp As String
        Public Property lacUnidTransp As LacUnidTransp()
        Public Property infUnidCarga As InfUnidCarga()
        Public Property qtdRat As String
    End Class

    Public Class Peri
        Public Property nONU As String
        Public Property xNomeAE As String
        Public Property xClaRisco As String
        Public Property grEmb As String
        Public Property qTotProd As String
        Public Property qVolTipo As String
    End Class

    Public Class InfCTe
        Public Property chCTe As String
        Public Property SegCodBarra As String
        Public Property indReentrega As String
        Public Property infUnidTransp As InfUnidTransp()
        Public Property peri As Peri()
    End Class

    Public Class InfNFe
        Public Property chNFe As String
        Public Property SegCodBarra As String
        Public Property indReentrega As String
        Public Property infUnidTransp As InfUnidTransp()
        Public Property peri As Peri()
    End Class

    Public Class InfMDFeTransp
        Public Property chMDFe As String
        Public Property indReentrega As String
        Public Property infUnidTransp As InfUnidTransp()
        Public Property peri As Peri()
    End Class

    Public Class InfMunDescarga
        Public Property cMunDescarga As String
        Public Property xMunDescarga As String
        Public Property infCTe As InfCTe()
        Public Property infNFe As InfNFe()
        Public Property infMDFeTransp As InfMDFeTransp()
    End Class

    Public Class InfDoc
        Public Property infMunDescarga As InfMunDescarga()
    End Class

    Public Class InfResp
        Public Property respSeg As String
        Public Property CNPJ As String
        Public Property CPF As String
    End Class

    Public Class InfSeg
        Public Property xSeg As String
        Public Property CNPJ As String
    End Class

    Public Class Seg
        Public Property infResp As InfResp
        Public Property infSeg As InfSeg
        Public Property nApol As String
        Public Property nAver As String()
    End Class

    Public Class Tot
        Public Property qCTe As String
        Public Property qNFe As String
        Public Property qMDFe As String
        Public Property vCarga As String
        Public Property cUnid As String
        Public Property qCarga As String
    End Class

    Public Class Lacre
        Public Property nLacre As String
    End Class

    Public Class AutXML
        Public Property CNPJ As String
        Public Property CPF As String
    End Class

    Public Class InfAdic
        Public Property infAdFisco As String
        Public Property infCpl As String
    End Class

    Public Class InfCIOT
        Public Property CIOT As String
        Public Property CPF As String
        Public Property CNPJ As String
    End Class

    Public Class Disp
        Public Property CNPJForn As String
        Public Property CNPJPg As String
        Public Property CPFPg As String
        Public Property nCompra As String
        Public Property vValePed As String
    End Class

    Public Class ValePed
        Public Property disp As Disp()
    End Class

    Public Class InfContratante
        Public Property CPF As String
        Public Property CNPJ As String
    End Class

    Public Class InfANTT
        Public Property RNTRC As String
        Public Property infCIOT As InfCIOT()
        Public Property valePed As ValePed
        Public Property infContratante As InfContratante()
    End Class

    Public Class Prop
        Public Property CPF As String
        Public Property CNPJ As String
        Public Property RNTRC As String
        Public Property xNome As String
        Public Property IE As String
        Public Property UF As String
        Public Property tpProp As String
    End Class

    Public Class Condutor
        Public Property xNome As String
        Public Property CPF As String
    End Class

    Public Class VeicTracao
        Public Property [cInt] As String
        Public Property placa As String
        Public Property RENAVAM As String
        Public Property tara As String
        Public Property capKG As String
        Public Property capM3 As String
        Public Property prop As Prop
        Public Property condutor As Condutor()
        Public Property tpRod As String
        Public Property tpCar As String
        Public Property UF As String
    End Class

    Public Class VeicReboque
        Public Property [cInt] As String
        Public Property placa As String
        Public Property RENAVAM As String
        Public Property tara As String
        Public Property capKG As String
        Public Property capM3 As String
        Public Property prop As Prop
        Public Property tpCar As String
        Public Property UF As String
    End Class

    Public Class LacRodo
        Public Property nLacre As String
    End Class

    Public Class Rodo
        Public Property infANTT As InfANTT
        Public Property veicTracao As VeicTracao
        Public Property veicReboque As VeicReboque()
        Public Property codAgPorto As String
        Public Property lacRodo As LacRodo()
    End Class

    Public Class Aereo
        Public Property nac As String
        Public Property matr As String
        Public Property nVoo As String
        Public Property cAerEmb As String
        Public Property cAerDes As String
        Public Property dVoo As String
    End Class

    Public Class InfTermCarreg
        Public Property cTermCarreg As String
        Public Property xTermCarreg As String
    End Class

    Public Class InfTermDescarreg
        Public Property cTermDescarreg As String
        Public Property xTermDescarreg As String
    End Class

    Public Class InfEmbComb
        Public Property cEmbComb As String
        Public Property xBalsa As String
    End Class

    Public Class InfUnidCargaVazia
        Public Property idUnidCargaVazia As String
        Public Property tpUnidCargaVazia As String
    End Class

    Public Class InfUnidTranspVazia
        Public Property idUnidTranspVazia As String
        Public Property tpUnidTranspVazia As String
    End Class

    Public Class Aquav
        Public Property irin As String
        Public Property tpEmb As String
        Public Property cEmbar As String
        Public Property xEmbar As String
        Public Property nViag As String
        Public Property cPrtEmb As String
        Public Property cPrtDest As String
        Public Property prtTrans As String
        Public Property tpNav As String
        Public Property infTermCarreg As InfTermCarreg()
        Public Property infTermDescarreg As InfTermDescarreg()
        Public Property infEmbComb As InfEmbComb()
        Public Property infUnidCargaVazia As InfUnidCargaVazia()
        Public Property infUnidTranspVazia As InfUnidTranspVazia()
    End Class

    Public Class Trem
        Public Property xPref As String
        Public Property dhTrem As String
        Public Property xOri As String
        Public Property xDest As String
        Public Property qVag As String
    End Class

    Public Class Vag
        Public Property pesoBC As String
        Public Property pesoR As String
        Public Property tpVag As String
        Public Property serie As String
        Public Property nVag As String
        Public Property nSeq As String
        Public Property TU As String
    End Class

    Public Class Ferrov
        Public Property trem As Trem
        Public Property vag As Vag()
    End Class

    Public Class InfModal
        Public Property rodo As Rodo
        Public Property aereo As Aereo
        Public Property aquav As Aquav
        Public Property ferrov As Ferrov
        Public Property versaoModal As String
    End Class

    Public Class InfMDFe
        Public Property versao As String
        Public Property Id As String
        Public Property ide As Ide
        Public Property emit As Emit
        Public Property infDoc As InfDoc
        Public Property seg As Seg()
        Public Property tot As Tot
        Public Property lacres As Lacre()
        Public Property autXML As AutXML()
        Public Property infAdic As InfAdic
        Public Property infModal As InfModal
    End Class

    Public Class MDFe
        Public Property infMDFe As InfMDFe
    End Class

    Public Class MDFeJSON
        Public Property MDFe As MDFe
    End Class

End Namespace