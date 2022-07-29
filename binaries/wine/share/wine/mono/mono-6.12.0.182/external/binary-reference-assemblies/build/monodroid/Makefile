PROFILE := monodroid
SOURCEDIR := ../../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -debug- -target:library -nowarn:612,618,809
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := mscorlib System System.Xml System.Numerics System.Core System.Net.Http Mono.Android

ASSEMBLIES += bare/System bare/System.Xml

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
System.Core_REFS := mscorlib System
System.Net.Http_REFS := mscorlib System
Mono.Android_REFS := mscorlib
System.Numerics_REFS := mscorlib
System_REFS := mscorlib bare/System.Xml
System.Xml_REFS := mscorlib System

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := ../../src/mono/System.extra.cs

ECMA_KEY := ../../../../../mono/mcs/class/ecma.pub         # Public Key Token: b77a5c561934e089

ECMA_KEY_ASSEMBLIES := System.Core System.Net.Http System.Numerics System.Xml System mscorlib \
	bare/System bare/System.Xml

# Mono.Android must be signed with a different key (copied from xamarin-android repository)
Mono.Android_KEYFILE := xa.pub

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

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
