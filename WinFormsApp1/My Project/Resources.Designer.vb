﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DonateMoneyToReimu.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca una cadena traducida similar a INSERT INTO CONSEJO VALUES (1, &apos;La paciencia es la clave del éxito.&apos;);
        '''INSERT INTO CONSEJO VALUES (2, &apos;Aprende de tus errores y crece.&apos;);
        '''INSERT INTO CONSEJO VALUES (3, &apos;La perseverancia supera la habilidad.&apos;);
        '''INSERT INTO CONSEJO VALUES (4, &apos;La sabiduría es la verdadera riqueza.&apos;);
        '''INSERT INTO CONSEJO VALUES (5, &apos;El conocimiento es el poder.&apos;);
        '''INSERT INTO CONSEJO VALUES (6, &apos;La gratitud transforma la vida.&apos;);
        '''INSERT INTO CONSEJO VALUES (7, &apos;Sé amable, siempre.&apos;);
        '''INSERT INTO CONSEJO VALUES (8, &apos;La  [resto de la cadena truncado]&quot;;.
        '''</summary>
        Friend ReadOnly Property consejosList() As String
            Get
                Return ResourceManager.GetString("consejosList", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property donation_average() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("donation_average", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property donation_high() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("donation_high", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property donation_higher() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("donation_higher", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property donation_low() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("donation_low", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property fumo() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("fumo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property fumoFlip() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("fumoFlip", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property reimu() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("reimu", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
