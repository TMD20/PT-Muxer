PROFILE := v4.0
SOURCEDIR := ../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := Accessibility CustomMarshalers	\
	Microsoft.Build.Engine Microsoft.Build.Framework Microsoft.Build.Tasks.v4.0	\
	Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC	\
	System.ComponentModel.Composition	\
	System.ComponentModel.DataAnnotations System.Configuration.Install System.Configuration System.Core	\
	System.Data.DataSetExtensions System.Data.Linq System.Data.OracleClient	\
	System.Data.Services.Client System.Data.Services System.Data System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices	\
	System.IdentityModel.Selectors System.IdentityModel	System.Management System.Messaging	\
	System.Net System.Numerics System.Runtime.Caching System.Runtime.DurableInstancing System.Runtime.Remoting	\
	System.Runtime.Serialization.Formatters.Soap System.Runtime.Serialization System.Security System.ServiceModel.Activation	\
	System.ServiceModel.Discovery System.ServiceModel.Routing System.ServiceModel.Web	\
	System.ServiceModel System.ServiceProcess System.Transactions System.Web.Abstractions	\
	System.Web.ApplicationServices System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Routing System.Web.Services System.Web System.Windows.Forms.DataVisualization System.Windows.Forms System.Xaml System.Xml.Linq	\
	System.Xml System WindowsBase mscorlib

ASSEMBLIES += bare/System bare/System.Xml bare/System.Configuration bare/System.ServiceModel.Activation bare/System.Web

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
Accessibility_REFS := mscorlib
CustomMarshalers_REFS := mscorlib
Microsoft.Build.Engine_REFS := mscorlib System System.Xml Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0 System.Core
Microsoft.Build.Framework_REFS := mscorlib
Microsoft.Build.Tasks.v4.0_REFS := mscorlib Microsoft.Build.Utilities.v4.0 Microsoft.Build.Framework System System.Core System.Xml Microsoft.Build.Engine
Microsoft.Build.Utilities.v4.0_REFS := Microsoft.Build.Framework mscorlib System System.Xml
Microsoft.Build_REFS := mscorlib Microsoft.Build.Framework System System.Xml System.Core
Microsoft.CSharp_REFS := mscorlib System.Core
Microsoft.VisualBasic_REFS := mscorlib System System.Windows.Forms System.Drawing
Microsoft.VisualC_REFS := mscorlib
System.ComponentModel.Composition_REFS := mscorlib System.Core System
System.ComponentModel.DataAnnotations_REFS := mscorlib System System.Core
System.Configuration.Install_REFS := mscorlib System
System.Configuration_REFS := mscorlib System bare/System.Xml
System.Core_REFS := mscorlib System
System.Data.DataSetExtensions_REFS := System.Data mscorlib System.Core System
System.Data.Linq_REFS := mscorlib System.Data System System.Core System.Xml System.Runtime.Serialization
System.Data.OracleClient_REFS := mscorlib System.Data System System.EnterpriseServices System.Drawing
System.Data.Services.Client_REFS := mscorlib System.Core System System.Xml System.Xml.Linq
System.Data.Services_REFS := mscorlib System.Core System System.Data.Services.Client System.ServiceModel System.ServiceModel.Web System.ServiceModel.Activation
System.Data_REFS := mscorlib System System.Xml System.Configuration System.Transactions System.EnterpriseServices
System.Design_REFS := mscorlib System System.Windows.Forms System.Data System.Drawing System.Xml bare/System.Web System.Configuration
System.DirectoryServices.Protocols_REFS := mscorlib System System.Xml System.DirectoryServices
System.DirectoryServices_REFS := mscorlib System
System.Drawing.Design_REFS := System.Windows.Forms System.Drawing mscorlib System
System.Drawing_REFS := mscorlib System
System.Dynamic_REFS := mscorlib System.Core System
System.EnterpriseServices_REFS := mscorlib System.Transactions
System.IdentityModel.Selectors_REFS := System.Xml mscorlib System System.IdentityModel
System.IdentityModel_REFS := mscorlib System System.Web.ApplicationServices System.Xml System.Runtime.Serialization System.Security
System.Management_REFS := mscorlib System System.Configuration.Install
System.Messaging_REFS := mscorlib System System.Configuration.Install System.Xml System.Windows.Forms System.Drawing
System.Net_REFS := mscorlib System
System.Numerics_REFS := mscorlib
System.Runtime.Caching_REFS := mscorlib System System.Core System.Configuration System.Data
System.Runtime.DurableInstancing_REFS := mscorlib System.Xml.Linq
System.Runtime.Remoting_REFS := mscorlib System.Runtime.Serialization.Formatters.Soap System System.Xml System.Web
System.Runtime.Serialization.Formatters.Soap_REFS := System.Xml mscorlib
System.Runtime.Serialization_REFS := mscorlib System.Xml System System.Configuration System.Core
System.Security_REFS := mscorlib System.Xml System
System.ServiceModel.Activation_REFS := mscorlib System.ServiceModel System
System.ServiceModel.Discovery_REFS := System.ServiceModel System mscorlib System.Configuration System.Runtime.Serialization System.Xml System.Xml.Linq System.Core
System.ServiceModel.Routing_REFS := System.ServiceModel mscorlib System.Runtime.Serialization System System.Configuration System.Core
System.ServiceModel.Web_REFS := System.ServiceModel mscorlib System.Runtime.Serialization System.Configuration System System.Xml System.ServiceModel.Activation System.Core System.Web.Extensions
System.ServiceModel_REFS := mscorlib System System.Runtime.Serialization System.Xml System.Web System.IdentityModel System.Security System.Messaging System.Core System.Transactions System.Configuration System.Web.Services System.Web.ApplicationServices bare/System.ServiceModel.Activation System.IdentityModel.Selectors
System.ServiceProcess_REFS := System mscorlib System.Configuration.Install System.Windows.Forms
System.Transactions_REFS := mscorlib System.Configuration
System.Web.Abstractions_REFS := mscorlib System.Web
System.Web.ApplicationServices_REFS := System mscorlib System.Configuration
System.Web.DynamicData_REFS := mscorlib System.Data.Linq System System.Web System.Web.Extensions System.Core System.ComponentModel.DataAnnotations System.Drawing
System.Web.Extensions.Design_REFS := mscorlib System System.Design System.Drawing
System.Web.Extensions_REFS := mscorlib System.Core System System.Web System.Web.ApplicationServices System.Configuration System.Web.Services System.Xml System.ServiceModel System.Data.Linq System.Drawing
System.Web.Routing_REFS := mscorlib System.Web
System.Web.Services_REFS := System.EnterpriseServices bare/System.Web System.Configuration mscorlib System System.Xml
System.Web_REFS := System.Drawing mscorlib System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.Runtime.Serialization.Formatters.Soap System.Web.Services System.EnterpriseServices
System.Windows.Forms.DataVisualization_REFS := System.Drawing mscorlib System.Windows.Forms System System.Core System.Xml System.Data
System.Windows.Forms_REFS := mscorlib System System.Xml System.Drawing System.Configuration System.Runtime.Serialization.Formatters.Soap Accessibility System.Data
System.Xaml_REFS := mscorlib System System.Xml System.Core
System.Xml.Linq_REFS := mscorlib System.Xml System.Core
System.Xml_REFS := mscorlib System System.Configuration
System_REFS := mscorlib bare/System.Configuration bare/System.Xml
WindowsBase_REFS := mscorlib System System.Xml System.Xaml
mscorlib_REFS :=

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System
bare/System.Configuration_REFS := mscorlib bare/System bare/System.Xml
bare/System.ServiceModel.Activation_REFS := mscorlib System
bare/System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.ComponentModel.DataAnnotations System.EnterpriseServices

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := -d:CONFIG_DEP -d:XML_DEP
System.Configuration_CSC_ARGS := -d:CONFIG_DEP
System.Xml_CSC_ARGS := -d:CONFIG_DEP
System.ServiceModel.Activation_CSC_ARGS := -d:SERVICEMODEL_DEP
System.Web_CSC_ARGS := -d:SERVICES_DEP

ECMA_KEY := ../../../mcs/class/ecma.pub
WINFX_KEY := ../../../mcs/class/winfx.pub
MSFINAL_KEY := ../../../mcs/class/msfinal.pub

ECMA_KEY_ASSEMBLIES := System.ComponentModel.Composition System.Core System.Data.DataSetExtensions	\
	System.Data.Linq System.Data.OracleClient System.Data.Services.Client System.Data.Services	\
	System.Data System.IdentityModel.Selectors System.IdentityModel	\
	System.Dynamic System.Numerics System.Runtime.Remoting System.Runtime.Serialization	\
	System.ServiceModel System.Transactions System.Windows.Forms System.Xaml	\
	System.Xml.Linq System.Xml System mscorlib bare/System bare/System.Xml

WINFX_KEY_ASSEMBLIES := System.ComponentModel.DataAnnotations	\
	System.Runtime.DurableInstancing System.ServiceModel.Activation System.ServiceModel.Discovery System.ServiceModel.Routing	\
	System.ServiceModel.Web System.Web.Abstractions System.Web.ApplicationServices System.Web.DynamicData	\
	System.Web.Extensions.Design System.Web.Extensions System.Web.Routing	\
	System.Windows.Forms.DataVisualization WindowsBase bare/System.ServiceModel.Activation

MSFINAL_KEY_ASSEMBLIES := Accessibility CustomMarshalers Microsoft.Build.Engine Microsoft.Build.Framework	\
	Microsoft.Build.Tasks.v4.0 Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualBasic Microsoft.VisualC	\
	System.Configuration.Install System.Configuration System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.EnterpriseServices System.Management	\
	System.Messaging System.Net System.Runtime.Caching	\
	System.Runtime.Serialization.Formatters.Soap System.Security System.ServiceProcess System.Web.Services	\
	System.Web bare/System.Configuration bare/System.Web

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addsuffix .dll, $($(1)_REFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:, $(addsuffix .dll, $($(1)_REFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(ECMA_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),   $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
