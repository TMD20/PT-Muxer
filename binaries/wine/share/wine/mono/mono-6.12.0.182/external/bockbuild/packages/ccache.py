GitHubPackage('kumpera', 'ccache', '3.1.9',
              revision='55f1fc61765c96ce5ac90e253bab4d8feddea828',
              configure='./autogen.sh --prefix="%{package_prefix}"; CC=cc ./configure --prefix="%{package_prefix}"',
              override_properties={'build_dependency': True}
              )
