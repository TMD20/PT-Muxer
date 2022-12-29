# Machine Parse

## Machine Parse

### Subtitles

**OCR**

Subtitles can be ocr with the --ocr command. This will run one of two ocr engines. Easyocr tends to give better results, but it has about 100 languages. Tesseract is able to ocr over 130 languages.&#x20;

Currently the use of this is to help with ID tracks.

This process can take a while, so by default it is turned off

To speed things up a bit by default only the last lines, and the first 50 lines will be ocr.

You can change this by changing the maxOCRLineCount value in config.py => see advanced subpages in doc



**Subimages**

If a sub is selected to be ocr then temp images will be generated. By default the value will be set to none, which means no subtitles will be ocr

If you want to keep the temp images  generated for the ocr process permanently you can pass both the --ocr and --keepocr arguments

#### **Subimages** images without OCR

It is also possible to generate subimages for all enabled tracks without having to process them with ocr.&#x20;

pass the  --keepocr language argument, without --ocr argument

As a note if you want a little more control of what tracks are enabled you can pass both the&#x20;

\--sublang arguments and --sortpref arguments



### voiceRec

voiceRec is not as good as ocr. But it can still kind of be used to ID tracks. Use the --voicerec argument  to use this feature. To save time it will only record about 50 lines worth of the track.



You can change this by changing the maxVoiceLineCount value in config.py => see advanced subpages in doc
