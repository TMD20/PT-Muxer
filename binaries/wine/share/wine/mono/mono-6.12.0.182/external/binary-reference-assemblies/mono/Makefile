PROFILE := mono
SOURCEDIR := ../src/$(PROFILE)/
BCL_PROFILE := ../v4.6/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := cscompmgd Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N IBM.Data.DB2 ICSharpCode.SharpZipLib	\
	Microsoft.Web.Infrastructure Mono.C5 Mono.CSharp Mono.Cairo Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Options Mono.Parallel Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI RabbitMQ.Client WebMatrix.Data bare/Mono.Cecil	\
	SMDiagnostics System.Json.Microsoft System.Json System.Net.Http.Formatting System.Numerics.Vectors	\
	System.Reactive.Core System.Reactive.Debugger System.Reactive.Experimental System.Reactive.Interfaces System.Reactive.Linq System.Reactive.Observable.Aliases	\
	System.Reactive.PlatformServices System.Reactive.Providers System.Reactive.Runtime.Remoting System.Reactive.Windows.Forms System.Reactive.Windows.Threading	\
	System.Threading.Tasks.Dataflow System.Web.Http.SelfHost System.Web.Http.WebHost System.Web.Http System.Web.Mvc System.Web.Razor \
	System.Web.WebPages.Deployment System.Web.WebPages.Razor System.Web.WebPages

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
cscompmgd_REFS := mscorlib System
Commons.Xml.Relaxng_REFS := mscorlib System.Xml System
I18N.CJK_REFS := mscorlib
I18N.MidEast_REFS := mscorlib
I18N.Other_REFS := mscorlib
I18N.Rare_REFS := mscorlib
I18N.West_REFS := mscorlib
I18N_REFS := mscorlib
IBM.Data.DB2_REFS := mscorlib System System.Data
ICSharpCode.SharpZipLib_REFS := mscorlib System
Microsoft.Web.Infrastructure_REFS := mscorlib System System.Web
Mono.C5_REFS := mscorlib
Mono.CSharp_REFS := mscorlib System System.Core System.Xml
Mono.Cairo_REFS := mscorlib
Mono.CodeContracts_REFS := mscorlib System.Core System
Mono.CompilerServices.SymbolWriter_REFS := mscorlib System
Mono.Data.Sqlite_REFS := mscorlib System.Data System System.Transactions
Mono.Data.Tds_REFS := mscorlib System
Mono.Debugger.Soft_REFS := mscorlib System.Core System
Mono.Http_REFS := mscorlib System System.Web System.Xml
Mono.Management_REFS := mscorlib System
Mono.Messaging.RabbitMQ_REFS := mscorlib System
Mono.Messaging_REFS := mscorlib System System.Configuration
Mono.Options_REFS := mscorlib System
Mono.Parallel_REFS := mscorlib
Mono.Posix_REFS := mscorlib System
Mono.Security.Win32_REFS := mscorlib
Mono.Security_REFS := mscorlib System
Mono.Simd_REFS := mscorlib
Mono.Tasklets_REFS := mscorlib
Mono.WebBrowser_REFS := mscorlib System
Novell.Directory.Ldap_REFS := mscorlib System
PEAPI_REFS := mscorlib
RabbitMQ.Client_REFS := mscorlib System.Xml System
WebMatrix.Data_REFS := mscorlib System.Data System.Core System System.Configuration
SMDiagnostics_REFS := mscorlib System.Configuration System System.Xml
System.Json.Microsoft_REFS := mscorlib System.Runtime.Serialization System System.Xml System.Core
System.Json_REFS := mscorlib System System.Core
System.Net.Http.Formatting_REFS := mscorlib System System.Xml System.Xml.Linq System.Runtime.Serialization System.Core System.Data System.Net.Http System.Configuration
System.Numerics.Vectors_REFS := mscorlib System.Numerics
System.Reactive.Core_REFS := mscorlib System System.Core
System.Reactive.Debugger_REFS := mscorlib
System.Reactive.Experimental_REFS := mscorlib System.Core System
System.Reactive.Interfaces_REFS := mscorlib System.Core
System.Reactive.Linq_REFS := mscorlib System.Core System
System.Reactive.Observable.Aliases_REFS := mscorlib System.Core
System.Reactive.PlatformServices_REFS := mscorlib System System.Core
System.Reactive.Providers_REFS := mscorlib System.Core System
System.Reactive.Runtime.Remoting_REFS := mscorlib System.Core
System.Reactive.Windows.Forms_REFS := mscorlib System.Windows.Forms
System.Reactive.Windows.Threading_REFS := mscorlib System WindowsBase
System.Threading.Tasks.Dataflow_REFS := mscorlib System.Core System
System.Web.Http.SelfHost_REFS := mscorlib System System.ServiceModel System.Net.Http System.Core System.IdentityModel System.Runtime.Serialization System.Configuration System.Xml
System.Web.Http.WebHost_REFS := mscorlib System.Web System.Core System System.Net.Http System.Xml
System.Web.Http_REFS := mscorlib System System.Net.Http System.Core System.ComponentModel.DataAnnotations System.Runtime.Serialization System.Xml System.Data.Linq
System.Web.Mvc_REFS := mscorlib System.Web System System.Core System.ComponentModel.DataAnnotations System.Web.Extensions System.Runtime.Caching System.Xml System.Data.Linq
System.Web.Razor_REFS := mscorlib System System.Core
System.Web.WebPages.Deployment_REFS := mscorlib System.Web System System.Configuration System.Core
System.Web.WebPages.Razor_REFS := mscorlib System.Web System System.Configuration System.Core
System.Web.WebPages_REFS := mscorlib System.Web System System.Core System.Xml.Linq System.ComponentModel.DataAnnotations System.Data.Linq Microsoft.CSharp

bare/Mono.Cecil_REFS := mscorlib

I18N.CJK_MONOREFS := I18N
I18N.MidEast_MONOREFS := I18N
I18N.Other_MONOREFS := I18N
I18N.Rare_MONOREFS := I18N
I18N.West_MONOREFS := I18N
Mono.Debugger.Soft_MONOREFS := bare/Mono.Cecil
Mono.Messaging.RabbitMQ_MONOREFS := Mono.Messaging RabbitMQ.Client
System.Reactive.Core_MONOREFS := System.Reactive.Interfaces
System.Reactive.Debugger_MONOREFS := System.Reactive.Linq
System.Reactive.Experimental_MONOREFS := System.Reactive.Linq System.Reactive.Core System.Reactive.Interfaces
System.Reactive.Linq_MONOREFS :=System.Reactive.Interfaces System.Reactive.Core
System.Reactive.Observable.Aliases_MONOREFS := System.Reactive.Interfaces System.Reactive.Providers System.Reactive.Linq
System.Reactive.PlatformServices_MONOREFS := System.Reactive.Core System.Reactive.Interfaces System.Reactive.Linq
System.Reactive.Providers_MONOREFS := System.Reactive.Interfaces System.Reactive.Core System.Reactive.Linq
System.Reactive.Runtime.Remoting_MONOREFS := System.Reactive.Interfaces System.Reactive.Core
System.Reactive.Windows.Forms_MONOREFS := System.Reactive.Core System.Reactive.Interfaces
System.Reactive.Windows.Threading_MONOREFS := System.Reactive.Core System.Reactive.Interfaces
System.Web.Http.SelfHost_MONOREFS := System.Web.Http System.Net.Http.Formatting
System.Web.Http.WebHost_MONOREFS := System.Web.Http Microsoft.Web.Infrastructure
System.Web.Http_MONOREFS := System.Net.Http.Formatting
System.Web.Mvc_MONOREFS := System.Web.WebPages.Razor System.Web.WebPages System.Web.Razor Microsoft.Web.Infrastructure
System.Web.WebPages.Deployment_MONOREFS := Microsoft.Web.Infrastructure
System.Web.WebPages.Razor_MONOREFS := System.Web.Razor System.Web.WebPages
System.Web.WebPages_MONOREFS := System.Web.Razor Microsoft.Web.Infrastructure System.Web.WebPages.Deployment

MONO_KEY := ../../../mcs/class/mono.pub         # Public Key Token: 0738eb9f132ed756
ECMA_KEY := ../../../mcs/class/ecma.pub         # Public Key Token: b77a5c561934e089
WINFX_KEY := ../../../mcs/class/winfx.pub       # Public Key Token: 31bf3856ad364e35
MSFINAL_KEY := ../../../mcs/class/msfinal.pub   # Public Key Token: b03f5f7f11d50a3a

IBM.Data.DB2_KEYFILE := ../../../mcs/class/IBM.Data.DB2/ibm.pub
ICSharpCode.SharpZipLib_KEYFILE := ../../../mcs/class/ICSharpCode.SharpZipLib/SharpZipLib.pub
Mono.C5_KEYFILE := ../../../mcs/class/Mono.C5/c5.pub

MONO_KEY_ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	Mono.CSharp Mono.Cairo Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging	\
	Mono.Options Mono.Parallel Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser	\
	Novell.Directory.Ldap PEAPI WebMatrix.Data bare/Mono.Cecil

ECMA_KEY_ASSEMBLIES := SMDiagnostics System.Threading.Tasks.Dataflow

WINFX_KEY_ASSEMBLIES := Microsoft.Web.Infrastructure System.Json.Microsoft System.Json System.Net.Http.Formatting	\
	System.Reactive.Core System.Reactive.Debugger System.Reactive.Experimental	\
	System.Reactive.Interfaces System.Reactive.Linq System.Reactive.Observable.Aliases System.Reactive.PlatformServices	\
	System.Reactive.Providers System.Reactive.Runtime.Remoting System.Reactive.Windows.Forms System.Reactive.Windows.Threading	\
	System.Web.Http.SelfHost System.Web.Http.WebHost System.Web.Http System.Web.Mvc System.Web.Razor 	\
	System.Web.WebPages.Deployment System.Web.WebPages.Razor System.Web.WebPages

MSFINAL_KEY_ASSEMBLIES := cscompmgd RabbitMQ.Client System.Numerics.Vectors

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addprefix $(BCL_PROFILE), $(addsuffix .dll, $($(1)_REFS))) $(addsuffix .dll, $($(1)_MONOREFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:$(BCL_PROFILE), $(addsuffix .dll, $($(1)_REFS))) $(addprefix -r:, $(addsuffix .dll, $($(1)_MONOREFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(MONO_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MONO_KEY))))
$(foreach asm, $(ECMA_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),   $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
