'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace Properties


	<System.Runtime.CompilerServices.CompilerGeneratedAttribute> _
	<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits Global.System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = DirectCast(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<System.Configuration.ApplicationScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)> _
		<System.Configuration.DefaultSettingValueAttribute("Data Source=CARLOS_ESPINOSA\SQLEXPRESS;Initial Catalog=BDEmpresa;Integrated Secur" & "ity=True")> _
		Public ReadOnly Property BDEmpresaConnectionString() As String
			Get
				Return DirectCast(Me("BDEmpresaConnectionString"), String)
			End Get
		End Property
	End Class
End Namespace
