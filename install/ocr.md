# OCR

PTMuxer provides optional OCR of sup files.

Currently this can be used to ID tracks based on the content.

Enabling requires configuring at least one of two engines.

### Tesseract OCR

Tesseract OCR Provides the highest level of language compatibility in PTMuxer.&#x20;

A downside is that it requires packages on the host system. Meaning that typically root would access would be required on a Linux Box.



#### Requirements

Visit repo for instrucions on how to install required binaries

```
https://github.com/sirfz/tesserocr
```



However this package does require that tesseract binary be installed on the system

If you don't have sudo or dont want to install the requirements. Then easyocr might be a good choice

#### Install

You can install the module with&#x20;

```
CPPFLAGS=-I/usr/local/include pip3 install tesserocr
```

#### Windows Support

Windows Releases with all required libraries are provided.&#x20;

They are specific to each python version

https://github.com/simonflueckiger/tesserocr-windows\_build/releases



### EasyOCR

As the name implies this program is easy to install, and use

It does not provide nearly as many languages as Tesseract. However, it still supports 80+ languages. So you will find that the most popular languages are included.&#x20;

#### Windows Support

You may get errors mentioning torch on windows machines

If this happens manually configuration of the torch module may be required

Running this command may fix the issue

```
pip3 install torch torchvision torchaudio --extra-index-url https://download.pytorch.org/whl/cu116
```
