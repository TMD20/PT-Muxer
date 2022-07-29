PROFILE := v4.6
SOURCEDIR := ../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := Accessibility CustomMarshalers	\
	Microsoft.Build.Engine Microsoft.Build.Framework Microsoft.Build.Tasks.v4.0	\
	Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC	\
	System.ComponentModel.Composition	\
	System.ComponentModel.DataAnnotations System.Configuration.Install System.Configuration System.Core	\
	System.Data.DataSetExtensions System.Data.Entity System.Data.Linq System.Data.OracleClient	\
	System.Data.Services.Client System.Data.Services System.Data System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices	\
	System.IO.Compression.FileSystem System.IO.Compression System.IdentityModel.Selectors System.IdentityModel	\
	System.Management System.Messaging	\
	System.Net.Http.WebRequest System.Net.Http System.Net System.Numerics	\
	System.Runtime.Caching System.Runtime.DurableInstancing System.Runtime.Remoting	\
	System.Runtime.Serialization.Formatters.Soap System.Runtime.Serialization System.Security System.ServiceModel.Activation	\
	System.ServiceModel.Discovery System.ServiceModel.Internals System.ServiceModel.Routing System.ServiceModel.Web	\
	System.ServiceModel System.ServiceProcess System.Transactions System.Web.Abstractions	\
	System.Web.ApplicationServices System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Routing System.Web.Services System.Web	\
	System.Windows.Forms.DataVisualization System.Windows.Forms System.Windows System.Xaml System.Xml.Linq	\
	System.Xml.Serialization System.Xml System WindowsBase mscorlib	\
	System.Deployment System.Reflection.Context System.Runtime.InteropServices.RuntimeInformation	\
	System.Web.Mobile System.Web.RegularExpressions System.Workflow.Activities System.Workflow.ComponentModel System.Workflow.Runtime

ASSEMBLIES += bare/System bare/System.Xml bare/System.Configuration bare/System.ServiceModel.Activation bare/System.Web

FACADE_ASSEMBLIES := Facades/System.Collections.Concurrent Facades/System.Net.Primitives Facades/System.Runtime	\
	Facades/System.Collections Facades/System.Net.Requests Facades/System.Security.Principal	\
	Facades/System.ComponentModel.Annotations Facades/System.ObjectModel Facades/System.ServiceModel.Duplex	\
	Facades/System.ComponentModel.EventBasedAsync Facades/System.Reflection.Emit.ILGeneration Facades/System.ServiceModel.Http	\
	Facades/System.ComponentModel Facades/System.Reflection.Emit.Lightweight Facades/System.ServiceModel.NetTcp	\
	Facades/System.Diagnostics.Contracts Facades/System.Reflection.Emit Facades/System.ServiceModel.Primitives	\
	Facades/System.Diagnostics.Debug Facades/System.Reflection.Extensions Facades/System.ServiceModel.Security	\
	Facades/System.Diagnostics.Tools Facades/System.Reflection.Primitives Facades/System.Text.Encoding.Extensions	\
	Facades/System.Diagnostics.Tracing Facades/System.Reflection Facades/System.Text.Encoding	\
	Facades/System.Dynamic.Runtime Facades/System.Resources.ResourceManager Facades/System.Text.RegularExpressions	\
	Facades/System.Globalization Facades/System.Runtime.Extensions Facades/System.Threading.Tasks.Parallel	\
	Facades/System.IO Facades/System.Runtime.InteropServices.WindowsRuntime Facades/System.Threading.Tasks	\
	Facades/System.Linq.Expressions Facades/System.Runtime.InteropServices Facades/System.Threading.Timer	\
	Facades/System.Linq.Parallel Facades/System.Runtime.Numerics Facades/System.Threading	\
	Facades/System.Linq.Queryable Facades/System.Runtime.Serialization.Json Facades/System.Xml.ReaderWriter	\
	Facades/System.Linq Facades/System.Runtime.Serialization.Primitives Facades/System.Xml.XDocument	\
	Facades/System.Net.NetworkInformation Facades/System.Runtime.Serialization.Xml Facades/System.Xml.XmlSerializer	\
	Facades/System.Net.WebHeaderCollection Facades/System.Runtime.Handles

ASSEMBLIES += $(FACADE_ASSEMBLIES)

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
Accessibility_REFS := mscorlib
CustomMarshalers_REFS := mscorlib
Microsoft.Build.Engine_REFS := mscorlib System.Xml Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0 System System.Core
Microsoft.Build.Framework_REFS := mscorlib System
Microsoft.Build.Tasks.v4.0_REFS := mscorlib Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0 System Microsoft.Build.Engine System.Xml System.Core
Microsoft.Build.Utilities.v4.0_REFS := mscorlib Microsoft.Build.Framework System System.Xml
Microsoft.Build_REFS := mscorlib Microsoft.Build.Framework System.Xml System System.Core
Microsoft.CSharp_REFS := mscorlib System System.Core
Microsoft.VisualBasic_REFS := mscorlib System System.Windows.Forms System.Drawing
Microsoft.VisualC_REFS := mscorlib
System.ComponentModel.Composition_REFS := mscorlib System System.Core
System.ComponentModel.DataAnnotations_REFS := mscorlib System System.Core
System.Configuration.Install_REFS := mscorlib System
System.Configuration_REFS := mscorlib bare/System.Xml System
System.Core_REFS := mscorlib System
System.Data.DataSetExtensions_REFS := mscorlib System.Data System System.Core
System.Data.Entity_REFS := mscorlib System.Core System System.Data System.Runtime.Serialization System.ComponentModel.DataAnnotations System.Xml System.Xml.Linq System.Transactions System.Configuration
System.Data.Linq_REFS := mscorlib System.Data System.Core System System.Xml System.Runtime.Serialization
System.Data.OracleClient_REFS := mscorlib System.Data System System.Drawing System.EnterpriseServices System.Transactions
System.Data.Services.Client_REFS := mscorlib System System.Xml System.Core System.Xml.Linq
System.Data.Services_REFS := mscorlib System.Configuration System.ServiceModel System.ServiceModel.Web System System.ServiceModel.Activation System.Core System.Data.Services.Client
System.Data_REFS := mscorlib System.Configuration System.Xml System System.Numerics System.Core System.Transactions System.EnterpriseServices
System.Deployment_REFS := mscorlib
System.Design_REFS := mscorlib System.Drawing System.Drawing.Design System System.Windows.Forms System.Data bare/System.Web System.Configuration System.Xml
System.DirectoryServices.Protocols_REFS := mscorlib System.Xml System System.DirectoryServices
System.DirectoryServices_REFS := mscorlib System
System.Drawing.Design_REFS := mscorlib System.Drawing System.Windows.Forms System
System.Drawing_REFS := mscorlib System
System.Dynamic_REFS := mscorlib System.Core System
System.EnterpriseServices_REFS := mscorlib System.Transactions
System.IO.Compression.FileSystem_REFS := mscorlib System.IO.Compression System
System.IO.Compression_REFS := mscorlib System
System.IdentityModel.Selectors_REFS := mscorlib System.Xml System System.IdentityModel
System.IdentityModel_REFS := mscorlib System.Configuration System.Runtime.Serialization System.Security System System.Xml System.Web.ApplicationServices
System.Management_REFS := mscorlib System System.Configuration.Install
System.Messaging_REFS := mscorlib System System.Drawing System.Configuration.Install System.Xml System.Windows.Forms
System.Net.Http.WebRequest_REFS := mscorlib System.Net.Http System
System.Net.Http_REFS := mscorlib System System.Core
System.Net_REFS := mscorlib System
System.Numerics_REFS := mscorlib
System.Reflection.Context_REFS := mscorlib
System.Reflection.Metadata_REFS := System.Runtime System.Resources.ResourceManager System.Collections.Immutable System.Reflection.Primitives System.Diagnostics.Debug System.Collections System.IO System.IO.Compression System.Text.Encoding System.Runtime.InteropServices System.Linq System.Reflection System.Threading System.Runtime.Extensions System.Text.Encoding.Extensions System.Reflection.Extensions
System.Runtime.Caching_REFS := mscorlib System System.Data System.Configuration
System.Runtime.DurableInstancing_REFS := mscorlib System.Xml.Linq System.ServiceModel.Internals System.Transactions System.Core System.Runtime.Serialization System
System.Runtime.InteropServices.RuntimeInformation_REFS := mscorlib
System.Runtime.Remoting_REFS := mscorlib System System.Web System.Xml System.Runtime.Serialization.Formatters.Soap
System.Runtime.Serialization.Formatters.Soap_REFS := mscorlib System.Xml
System.Runtime.Serialization_REFS := mscorlib System.Xml System.ServiceModel.Internals System System.Configuration System.Core
System.Security_REFS := mscorlib System System.Xml
System.ServiceModel.Activation_REFS := mscorlib System.ServiceModel System System.Web
System.ServiceModel.Discovery_REFS := mscorlib System.ServiceModel System System.Xml System.Xml.Linq System.Runtime.Serialization System.Configuration System.Core
System.ServiceModel.Internals_REFS := mscorlib System System.Xml
System.ServiceModel.Routing_REFS := mscorlib System.ServiceModel System.Configuration System System.Runtime.Serialization
System.ServiceModel.Web_REFS := mscorlib System.ServiceModel System System.Runtime.Serialization System.Xml System.Xml.Linq System.Configuration System.ServiceModel.Activation System.Core System.Web.Extensions
System.ServiceModel_REFS := mscorlib System.Xml System.Xml.Linq System.Xaml System System.EnterpriseServices System.Transactions System.IdentityModel System.Runtime.Serialization System.Runtime.DurableInstancing System.Security System.Web.ApplicationServices System.Messaging System.Net.Http System.IdentityModel.Selectors System.Web.Services System.Configuration System.Web System.Core bare/System.ServiceModel.Activation
System.ServiceProcess_REFS := mscorlib System System.Configuration.Install System.Windows.Forms
System.Transactions_REFS := mscorlib System.Configuration
System.Web.Abstractions_REFS := mscorlib System.Web
System.Web.ApplicationServices_REFS := mscorlib System System.Configuration
System.Web.DynamicData_REFS := mscorlib System System.Drawing System.Web System.Web.Extensions System.Core System.ComponentModel.DataAnnotations System.Data.Linq
System.Web.Extensions.Design_REFS := mscorlib System System.Design System.Drawing System.Web.Extensions
System.Web.Extensions_REFS := mscorlib System.Web System System.Xml System.Drawing System.Data.Linq System.Web.Services System.ServiceModel System.ServiceModel.Activation System.Runtime.Serialization System.Web.ApplicationServices System.Core System.Configuration
System.Web.Mobile_REFS := mscorlib
System.Web.RegularExpressions_REFS := mscorlib System
System.Web.Routing_REFS := mscorlib System.Web
System.Web.Services_REFS := mscorlib System System.Configuration System.EnterpriseServices System.Xml bare/System.Web System.DirectoryServices System.Design System.Data
System.Web_REFS := mscorlib System.Configuration System.Xml System System.Data System.Drawing System.Runtime.Serialization.Formatters.Soap System.Core System.EnterpriseServices System.Web.ApplicationServices System.ComponentModel.DataAnnotations System.Web.Services
System.Windows.Forms.DataVisualization_REFS := mscorlib System.Drawing System.Windows.Forms System System.Xml System.Data System.Core
System.Windows.Forms_REFS := mscorlib System System.Xml System.Drawing System.Runtime.Serialization.Formatters.Soap Accessibility System.Configuration System.Data
System.Windows_REFS := mscorlib System
System.Workflow.Activities_REFS := mscorlib
System.Workflow.ComponentModel_REFS := mscorlib
System.Workflow.Runtime_REFS := mscorlib
System.Xaml_REFS := mscorlib System System.Xml System.Core
System.Xml.Linq_REFS := mscorlib System System.Runtime.Serialization System.Xml System.Core
System.Xml.Serialization_REFS := mscorlib System.ServiceModel System.Xml
System.Xml_REFS := mscorlib System System.Configuration
System_REFS := mscorlib bare/System.Configuration bare/System.Xml
WindowsBase_REFS := mscorlib System.Xaml System System.Xml System.Security
mscorlib_REFS :=

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System
bare/System.Configuration_REFS := mscorlib bare/System bare/System.Xml
bare/System.ServiceModel.Activation_REFS := mscorlib System
bare/System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.ComponentModel.DataAnnotations System.EnterpriseServices

Facades/System.Collections.Concurrent_REFS := mscorlib System
Facades/System.Collections_REFS := mscorlib System.Core System
Facades/System.ComponentModel.Annotations_REFS := mscorlib System.ComponentModel.DataAnnotations
Facades/System.ComponentModel.EventBasedAsync_REFS := mscorlib System
Facades/System.ComponentModel_REFS := mscorlib System
Facades/System.Diagnostics.Contracts_REFS := mscorlib
Facades/System.Diagnostics.Debug_REFS := mscorlib System
Facades/System.Diagnostics.Tools_REFS := mscorlib System
Facades/System.Diagnostics.Tracing_REFS := mscorlib
Facades/System.Dynamic.Runtime_REFS := mscorlib System.Core
Facades/System.Globalization_REFS := mscorlib
Facades/System.IO_REFS := mscorlib System
Facades/System.Linq.Expressions_REFS := mscorlib System.Core
Facades/System.Linq.Parallel_REFS := mscorlib System.Core
Facades/System.Linq.Queryable_REFS := mscorlib System.Core
Facades/System.Linq_REFS := mscorlib System.Core
Facades/System.Net.NetworkInformation_REFS := mscorlib System
Facades/System.Net.Primitives_REFS := mscorlib System
Facades/System.Net.Requests_REFS := mscorlib System
Facades/System.Net.WebHeaderCollection_REFS := mscorlib System
Facades/System.ObjectModel_REFS := mscorlib System
Facades/System.Reflection.Emit.ILGeneration_REFS := mscorlib
Facades/System.Reflection.Emit.Lightweight_REFS := mscorlib
Facades/System.Reflection.Emit_REFS := mscorlib
Facades/System.Reflection.Extensions_REFS := mscorlib
Facades/System.Reflection.Primitives_REFS := mscorlib
Facades/System.Reflection_REFS := mscorlib
Facades/System.Resources.ResourceManager_REFS := mscorlib
Facades/System.Runtime.Extensions_REFS := mscorlib System
Facades/System.Runtime.Handles_REFS := mscorlib System.Core
Facades/System.Runtime.InteropServices.WindowsRuntime_REFS := mscorlib
Facades/System.Runtime.InteropServices_REFS := mscorlib System.Core System
Facades/System.Runtime.Numerics_REFS := mscorlib System.Numerics
Facades/System.Runtime.Serialization.Json_REFS := mscorlib System.Runtime.Serialization
Facades/System.Runtime.Serialization.Primitives_REFS := mscorlib System.Runtime.Serialization
Facades/System.Runtime.Serialization.Xml_REFS := mscorlib System.Runtime.Serialization System Facades/System.Runtime.Serialization.Primitives
Facades/System.Runtime_REFS := mscorlib System.Core System System.ComponentModel.Composition
Facades/System.Security.Principal_REFS := mscorlib
Facades/System.ServiceModel.Duplex_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.Http_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.NetTcp_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.Primitives_REFS := mscorlib System.IdentityModel System.ServiceModel
Facades/System.ServiceModel.Security_REFS := mscorlib System.ServiceModel
Facades/System.Text.Encoding.Extensions_REFS := mscorlib
Facades/System.Text.Encoding_REFS := mscorlib
Facades/System.Text.RegularExpressions_REFS := mscorlib System
Facades/System.Threading.Tasks.Parallel_REFS := mscorlib
Facades/System.Threading.Tasks_REFS := mscorlib System.Core
Facades/System.Threading.Timer_REFS := mscorlib
Facades/System.Threading_REFS := mscorlib System System.Core
Facades/System.Xml.ReaderWriter_REFS := mscorlib System.Xml
Facades/System.Xml.XDocument_REFS := mscorlib System.Xml.Linq
Facades/System.Xml.XmlSerializer_REFS := mscorlib System.Xml

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := -d:CONFIG_DEP -d:XML_DEP
System.Configuration_CSC_ARGS := -d:CONFIG_DEP
System.Xml_CSC_ARGS := -d:CONFIG_DEP
System.ServiceModel.Activation_CSC_ARGS := -d:SERVICEMODEL_DEP -d:WEB_DEP
System.Web_CSC_ARGS := -d:SERVICES_DEP

ECMA_KEY := ../../../mcs/class/ecma.pub         # Public Key Token: b77a5c561934e089
WINFX_KEY := ../../../mcs/class/winfx.pub       # Public Key Token: 31bf3856ad364e35
MSFINAL_KEY := ../../../mcs/class/msfinal.pub   # Public Key Token: b03f5f7f11d50a3a

ECMA_KEY_ASSEMBLIES := System.ComponentModel.Composition System.Core System.Data.DataSetExtensions	\
	System.Data.Entity System.Data.Linq System.Data.OracleClient System.Data.Services.Client System.Data.Services	\
	System.Data System.IO.Compression.FileSystem System.IO.Compression System.IdentityModel.Selectors System.IdentityModel	\
	System.Numerics System.Reflection.Context System.Runtime.Remoting System.Runtime.Serialization System.ServiceModel.Internals	\
	System.ServiceModel System.Transactions System.Windows.Forms System.Xaml	\
	System.Xml.Linq System.Xml.Serialization System.Xml System mscorlib bare/System bare/System.Xml

WINFX_KEY_ASSEMBLIES := System.ComponentModel.DataAnnotations	\
	System.Runtime.DurableInstancing System.ServiceModel.Activation System.ServiceModel.Discovery System.ServiceModel.Routing	\
	System.ServiceModel.Web System.Web.Abstractions System.Web.ApplicationServices System.Web.DynamicData	\
	System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Routing	\
	System.Windows.Forms.DataVisualization System.Workflow.Activities System.Workflow.ComponentModel System.Workflow.Runtime	\
	WindowsBase bare/System.ServiceModel.Activation

MSFINAL_KEY_ASSEMBLIES := Accessibility CustomMarshalers Microsoft.Build.Engine Microsoft.Build.Framework	\
	Microsoft.Build.Tasks.v4.0 Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC	\
	System.Configuration.Install System.Configuration System.Deployment System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices System.Management	\
	System.Messaging System.Net.Http.WebRequest System.Net.Http System.Net System.Runtime.Caching	\
	System.Runtime.InteropServices.RuntimeInformation System.Runtime.Serialization.Formatters.Soap System.Security System.ServiceProcess System.Web.Services	\
	System.Web System.Web.Mobile System.Web.RegularExpressions System.Windows bare/System.Configuration bare/System.Web

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll
	rm -f Facades/*.dll

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addsuffix .dll, $($(1)_REFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	@mkdir -p Facades/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:, $(addsuffix .dll, $($(1)_REFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(ECMA_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),   $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))
$(foreach asm, $(FACADE_ASSEMBLIES),      $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
