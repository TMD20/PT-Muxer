GnomePackage('gtk-doc', version_major='1', version_minor='18', configure_flags=['--with-xml-catalog="%{staged_profile}/share/xml/catalog"'], sources=['http://ftp.gnome.org/pub/gnome/sources/%{name}/%{version}/%{name}-%{version}.tar.bz2'],
             override_properties={'build_dependency': True}
             )
