using System;
using System.Collections.Generic;
using System.Linq;

namespace YngveHestem.FileTypeInfo
{
	public static class FileTypes
	{
        /// <summary>
        /// List with many filetypes.
        /// </summary>
		public static readonly FileType[] Types = new FileType[]
		{
            //UTType defined in https://developer.apple.com/library/archive/documentation/Miscellaneous/Reference/UTIRef/Articles/System-DeclaredUniformTypeIdentifiers.html. MIME-types found in same document or other places online.
            //Table 1  System-defined uniform type identifiers
            new FileType("Text", new string[] { ".txt" }, new string[] { "text/plain" }, new string[] { "public.plain-text" }),
            new FileType("Rich Text", new string[] { ".rtf" }, new string[] { "text/rtf" }, new string[] { "public.rtf" }),
            new FileType("HTML", new string[] { ".html", ".htm" }, new string[] { "text/html" }, new string[] { "public.html" }),
            new FileType("XML", new string[] { ".xml" }, new string[] { "text/xml" }, new string[] { "public.xml" }),
            new FileType("C source code", new string[] { ".c" }, new string[] { "text/x-c" }, new string[] { "public.c-source" }),
            new FileType("Objective-C source code", new string[] { ".m" }, new string[] { "text/x-objective-c" }, new string[] { "public.objective-c-source" }),
            new FileType("C++ source code", new string[] { ".cp", ".cpp", ".c++", ".cc", ".cxx" }, new string[] { "text/x-c++" }, new string[] { "public.c-plus-plus-source" }),
            new FileType("Objective-C++ source code", new string[] { ".mm" }, new string[] { "text/x-objective-c" }, new string[] { "public.objective-c-plus-​plus-source" }),
            new FileType("C header file", new string[] { ".h" }, new string[] { "text/x-c" }, new string[] { "public.c-header" }),
            new FileType("C++ header file", new string[] { ".hpp", ".h++", ".hxx" }, new string[] { "text/x-c++" }, new string[] { "public.c-plus-plus-header" }),
            new FileType("Java source code", new string[] { ".java", ".jav" }, new string[] { "text/x-java-source" }, new string[] { "com.sun.java-source" }),
            new FileType("Assembly language source code", new string[] { ".s", ".asm" }, new string[] { "text/x-asm" }, new string[] { "public.assembly-source" }),
            new FileType("Rez source code", new string[] { ".r" }, new string[] {  }, new string[] { "com.apple.rez-source" }),
            new FileType("Mig definition source code", new string[] { ".defs", ".mig" }, new string[] {  }, new string[] { "public.mig-source" }),
            new FileType("Symbol export list", new string[] { ".exp" }, new string[] {  }, new string[] { "com.apple.symbol-export" }),
            new FileType("JavaScript", new string[] { ".js", ".jscript", ".javascript" }, new string[] { "text/javascript" }, new string[] { "com.netscape.javascript-​source" }),
            new FileType("Shell script", new string[] { ".sh", ".command" }, new string[] { "application/x-sh", "application/x-shellscript" }, new string[] { "public.shell-script" }),
            new FileType("C-shell script", new string[] { ".csh" }, new string[] { "application/x-csh" }, new string[] { "public.csh-script" }),
            new FileType("Perl script", new string[] { ".pl", ".pm" }, new string[] { "application/x-perl", "text/x-perl-script" }, new string[] { "public.perl-script" }),
            new FileType("Python script", new string[] { ".py" }, new string[] { "text/x-python", "text/x-python-script" }, new string[] { "public.python-script" }),
            new FileType("Ruby script", new string[] { ".rb", ".rbw" }, new string[] { "text/ruby-script" }, new string[] { "public.ruby-script" }),
            new FileType("PHP script", new string[] { ".php", ".php3", ".php4", ".ph3", ".ph4", ".phtml" }, new string[] { "text/x-php-script", "text/php", "application/php" }, new string[] { "public.php-script" }),
            new FileType("Java web start", new string[] { ".jnlp" }, new string[] { "application/x-java", "application/jnlp", "application/x-java-jnlp-file" }, new string[] { "com.sun.java-web-start" }),
            new FileType("AppleScript text", new string[] { ".applescript" }, new string[] { "text/plain" }, new string[] { "com.apple.applescript.text" }),
            new FileType("AppleScript", new string[] { ".scpt" }, new string[] { "application/x-applescript" }, new string[] { "com.apple.applescript.​script" }),
            new FileType("Object code", new string[] { ".o" }, new string[] { "application/octet-stream" }, new string[] { "public.object-code" }),
            new FileType("Microsoft Windows application", new string[] { ".exe" }, new string[] { "application/x-msdownload" }, new string[] { "com.microsoft.windows-​executable" }),
            new FileType("Microsoft dynamic link library", new string[] { ".dll" }, new string[] { "application/x-msdownload" }, new string[] { "com.microsoft.windows-​dynamic-link-library" }),
            new FileType("Java class", new string[] { ".class" }, new string[] { "application/java-vm" }, new string[] { "com.sun.java-class" }),
            new FileType("Java archive", new string[] { ".jar" }, new string[] { "application/java-archive" }, new string[] { "com.sun.java-archive" }),
            new FileType("Quartz Composer composition", new string[] { ".qtz" }, new string[] { "application/x-quartzcomposer" }, new string[] { "com.apple.quartz-​composer-composition" }),
            new FileType("GNU archive", new string[] { ".gtar" }, new string[] { "application/x-gtar" }, new string[] { "org.gnu.gnu-tar-archive" }),
            new FileType("Tar archive", new string[] { ".tar" }, new string[] { "application/x-tar", "application/tar" }, new string[] { "public.tar-archive" }),
            new FileType("Gzip archive", new string[] { ".gz", ".gzip" }, new string[] { "application/x-gzip", "application/gzip" }, new string[] { "org.gnu.gnu-zip-archive" }),
            new FileType("Gzip tar archive", new string[] { ".tgz" }, new string[] { "application/x-gzip", "application/gzip" }, new string[] { "org.gnu.gnu-zip-tar-archive" }),
            new FileType("BinHex archive", new string[] { ".hqx" }, new string[] { "application/mac-binhex40", "application/mac-binhex", "application/binhex" }, new string[] { "com.apple.binhex-archive" }),
            new FileType("MacBinary archive", new string[] { ".bin" }, new string[] { "application/x-macbinary", "application/macbinary" }, new string[] { "com.apple.macbinary-​archive" }),
            new FileType("vCard (electronic business card)", new string[] { ".vcf", ".vcard" }, new string[] { "text/directory", "text/vcard", "text/x-vcard" }, new string[] { "public.vcard" }),
            new FileType("JPEG image", new string[] { ".jpg", ".jpeg" }, new string[] { "image/jpeg" }, new string[] { "public.jpeg" }),
            new FileType("JPEG 2000 image", new string[] { ".jp2" }, new string[] { "image/jp2" }, new string[] { "public.jpeg-2000" }),
            new FileType("TIFF image", new string[] { ".tif", ".tiff" }, new string[] { "image/tiff" }, new string[] { "public.tiff" }),
            new FileType("PICT image", new string[] { ".pic", ".pct", ".pict" }, new string[] { "image/pict", "image/x-pict", "image/x-macpict" }, new string[] { "com.apple.pict" }),
            new FileType("MacPaint image", new string[] { ".pntg" }, new string[] { "image/x-macpaint" }, new string[] { "com.apple.macpaint-image" }),
            new FileType("PNG image", new string[] { ".png" }, new string[] { "image/png" }, new string[] { "public.png" }),
            new FileType("X bitmap image", new string[] { ".xbm" }, new string[] { "image/x-quicktime" }, new string[] { "public.xbitmap-image" }),
            new FileType("QuickTime image", new string[] { ".qif", ".qtif" }, new string[] { "image/x-quicktime" }, new string[] { "com.apple.quicktime-image" }),
            new FileType("Mac OS icon image", new string[] { ".icns" }, new string[] { "image/x-icns" }, new string[] { "com.apple.icns" }),
            new FileType("QuickTime movie", new string[] { ".mov", ".qt" }, new string[] { "video/quicktime" }, new string[] { "com.apple.quicktime-movie" }),
            new FileType("AVI movie", new string[] { ".avi", ".vfw" }, new string[] { "video/avi", "video/msvideo", "video/x-msvideo" }, new string[] { "public.avi" }),
            new FileType("MPEG-1 or MPEG-2 content", new string[] { ".mpg", ".mpeg", ".m75", ".m15" }, new string[] { "video/mpg", "video/mpeg", "video/x-mpg", "video/x-mpeg" }, new string[] { "public.mpeg" }),
            new FileType("MPEG-4 content", new string[] { ".mp4" }, new string[] { "video/mp4", "video/mp4v" }, new string[] { "public.mpeg-4" }),
            new FileType("3GPP movie", new string[] { ".3gp", ".3gpp" }, new string[] { "video/3gpp", "audio/3gpp" }, new string[] { "public.3gpp" }),
            new FileType("3GPP2 movie", new string[] { ".3g2", ".3gp2" }, new string[] { "video/3gpp2", "audio/3gpp2" }, new string[] { "public.3gpp2" }),
            new FileType("MPEG-3 audio", new string[] { ".mp3" }, new string[] { "audio/mpeg", "audio/mpeg3", "audio/mpg", "audio/mp3", "audio/x-mpeg", "audio/x-mpeg3", "audio/x-mpg", "audio/x-mp3" }, new string[] { "public.mp3" }),
            new FileType("MPEG-4 audio", new string[] { ".m4a" }, new string[] { "audio/mp4" }, new string[] { "public.mpeg-4-audio" }),
            new FileType("Protected MPEG-4 audio", new string[] { ".m4p", ".m4b" }, new string[] { "audio/mp4" }, new string[] { "com.apple.protected-​mpeg-4-audio" }),
            new FileType("μLaw audio", new string[] { ".au", ".ulw", ".snd" }, new string[] { "audio/basic", "audio/au", "audio/snd" }, new string[] { "public.ulaw-audio" }),
            new FileType("AIFF-C audio", new string[] { ".aifc", ".aiff", ".aif" }, new string[] { "audio/aiff", "audio/x-aiff" }, new string[] { "public.aifc-audio" }),
            new FileType("AIFF audio", new string[] { ".aiff", ".aif" }, new string[] { "audio/aiff", "audio/x-aiff" }, new string[] { "public.aiff-audio" }),
            new FileType("Core Audio format", new string[] { ".caf" }, new string[] { "audio/x-caf" }, new string[] { "com.apple.coreaudio-​format" }),
            new FileType("A directory with an internal structure specified by Core Foundation Bundle Services", new string[] { ".bundle" }, new string[] { "application/x-mach-binary" }, new string[] { "com.apple.bundle" }),
            new FileType("Application bundle", new string[] { ".app" }, new string[] { "inode/directory" }, new string[] { "com.apple.application-​bundle" }),
            new FileType("Plugin", new string[] { ".plugin" }, new string[] { "application/octet-stream" }, new string[] { "com.apple.plugin" }),
            new FileType("Spotlight importer plugin", new string[] { ".mdimporter" }, new string[] { "application/octet-stream" }, new string[] { "com.apple.metadata-​importer" }),
            new FileType("Dashboard widget", new string[] { ".wdgt" }, new string[] { "application/octet-stream" }, new string[] { "com.apple.dashboard-​widget" }),
            new FileType("CPIO archive", new string[] { ".cpio" }, new string[] { "application/x-cpio" }, new string[] { "public.cpio-archive" }),
            new FileType("Zip archive", new string[] { ".zip" }, new string[] { "application/zip" }, new string[] { "com.pkware.zip-archive" }),
            new FileType("Framework", new string[] { ".framework" }, new string[] { "application/octet-stream" }, new string[] { "com.apple.framework" }),
            new FileType("Rich Text Format Directory. That is, Rich Text with content embedding, on-disk format", new string[] { ".rtfd" }, new string[] { "application/octet-stream" }, new string[] { "com.apple.rtfd" }),
            new FileType("TrueType data fork font", new string[] { ".dfont" }, new string[] { "font/ttf" }, new string[] { "com.apple.truetype-​datafork-suitcase-font" }),
            new FileType("PostScript OpenType font", new string[] { ".otf" }, new string[] { "font/otf" }, new string[] { "public.opentype-font" }),
            new FileType("TrueType OpenType font", new string[] { ".ttf" }, new string[] { "font/ttf", "application/x-font-ttf" }, new string[] { "public.truetype-ttf-font" }),
            new FileType("TrueType collection font", new string[] { ".ttc" }, new string[] { "font/ttf", "application/x-font-ttf" }, new string[] { "public.truetype-collection-​font" }),
            new FileType("Font suitcase", new string[] { ".suit" }, new string[] { "application/octet-stream" }, new string[] { "com.apple.font-suitcase" }),
            new FileType("PostScriptType1 outline font", new string[] { ".pfb" }, new string[] { "application/x-font-type1" }, new string[] { "com.adobe.postscript-pfb-​font" }),
            new FileType("PostScriptType 1 outline font", new string[] { ".pfa" }, new string[] { "application/x-font" }, new string[] { "com.adobe.postscript.pfa-​font" }),
            new FileType("ColorSync profile", new string[] { ".icc", ".icm", ".pf" }, new string[] { "application/vnd.iccprofile" }, new string[] { "com.apple.colorsync-profile" }),
            //Table 3  Imported uniform type identifiers
            new FileType("PDF data", new string[] { ".pdf" }, new string[] { "application/pdf" }, new string[] { "com.adobe.pdf" }),
            new FileType("PostScript data", new string[] { ".ps" }, new string[] { "application/postscript" }, new string[] { "com.adobe.postscript" }),
            new FileType("Encapsulated PostScript", new string[] { ".eps" }, new string[] { "application/postscript" }, new string[] { "com.adobe.encapsulated-​postscript" }),
            new FileType("Adobe Photoshop document", new string[] { ".psd" }, new string[] { "image/x-photoshop", "image/photoshop", "image/psd", "application/photoshop" }, new string[] { "com.adobe.photoshop-​image" }),
            new FileType("Adobe Illustrator document", new string[] { ".ai" }, new string[] { "application/postscript" }, new string[] { "com.adobe.illustrator.ai-​imaget" }),
            new FileType("GIF image", new string[] { ".gif" }, new string[] { "image/gif" }, new string[] { "com.compuserve.gif" }),
            new FileType("Windows bitmap image", new string[] { ".bmp" }, new string[] { "image/bmp" }, new string[] { "com.microsoft.bmp" }),
            new FileType("Windows icon image", new string[] { ".ico" }, new string[] { "image/x-icon" }, new string[] { "com.microsoft.ico" }),
            new FileType("Microsoft Word data", new string[] { ".doc" }, new string[] { "application/msword" }, new string[] { "com.microsoft.word.doc" }),
            new FileType("Microsoft Excel data", new string[] { ".xls" }, new string[] { "application/vnd.ms-excel" }, new string[] { "com.microsoft.excel.xls" }),
            new FileType("Microsoft PowerPoint presentation", new string[] { ".ppt" }, new string[] { "application/mspowerpoint" }, new string[] { "com.microsoft.powerpoint.​ppt" }),
            new FileType("Waveform audio", new string[] { ".wav", ".wave" }, new string[] { "audio/wav", "audio/wave" }, new string[] { "com.microsoft.waveform-​audio" }),
            new FileType("Microsoft Advanced Systems format", new string[] { ".asf" }, new string[] { "video/x-ms-asf" }, new string[] { "com.microsoft.advanced-​systems-format" }),
            new FileType("Windows media", new string[] { ".wm" }, new string[] { "video/x-ms-wm" }, new string[] { "com.microsoft.windows-​media-wm" }),
            new FileType("Windows media", new string[] { ".wmv" }, new string[] { "video/x-ms-wmv" }, new string[] { "com.microsoft.windows-​media-wmv" }),
            new FileType("Windows media", new string[] { ".wmp" }, new string[] { "video/x-ms-wmp" }, new string[] { "com.microsoft.windows-​media-wmp" }),
            new FileType("Windows media audio", new string[] { ".wma" }, new string[] { "video/x-ms-wma", "audio/x-ms-wma" }, new string[] { "com.microsoft.windows-​media-wma" }),
            new FileType("Advanced Stream Redirector", new string[] { ".asx" }, new string[] { "video/x-ms-asx" }, new string[] { "com.microsoft.advanced-​stream-redirector" }),
            new FileType("Windows media", new string[] { ".wmx" }, new string[] { "video-x-ms-wmx" }, new string[] { "com.microsoft.windows-​media-wmx" }),
            new FileType("Windows media", new string[] { ".wvx" }, new string[] { "video-x-ms-wvx" }, new string[] { "com.microsoft.windows-​media-wvx" }),
            new FileType("Windows media audio", new string[] { ".wax" }, new string[] { "video-x-ms-wax", "audio/x-ms-wax" }, new string[] { "com.microsoft.windows-​media-wax" }),
            new FileType("Apple Keynote document", new string[] { ".key" }, new string[] { "inode/directory" }, new string[] { "com.apple.keynote.key" }),
            new FileType("Apple Keynote theme", new string[] { ".kth" }, new string[] { "inode/directory" }, new string[] { "com.apple.keynote.kth" }),
            new FileType("TGA image", new string[] { ".tga" }, new string[] { "image/targa", "image/tga", "application/tga" }, new string[] { "com.truevision.tga-image" }),
            new FileType("Silicon Graphics image", new string[] { ".sgi" }, new string[] { "image/sgi" }, new string[] { "com.sgi.sgi-image" }),
            new FileType("OpenEXR image", new string[] { ".exr" }, new string[] { "image/x-exr" }, new string[] { "com.ilm.openexr-image" }),
            new FileType("FlashPix image", new string[] { ".fpx" }, new string[] { "image/fpx", "application/vnd.fpx" }, new string[] { "com.kodak.flashpix.image" }),
            new FileType("J2 fax", new string[] { ".jfx" }, new string[] {  }, new string[] { "com.j2.jfx-fax" }),
            new FileType("eFax fax", new string[] { ".efx" }, new string[] { "image/efax" }, new string[] { "com.js.efx-fax" }),
            new FileType("Digidesign Sound Designer II audio", new string[] { ".sd2" }, new string[] { "audio/x-sd2" }, new string[] { "com.digidesign.sd2-audio" }),
            new FileType("RealMedia", new string[] { ".rm" }, new string[] { "application/vnd.rn-realmedia" }, new string[] { "com.real.realmedia" }),
            new FileType("RealMedia audio", new string[] { ".ram", ".ra" }, new string[] { "audio/vnd.rn-realaudio", "audio/x-pn-realaudio" }, new string[] { "com.real.realaudio" }),
            new FileType("Real synchronized multimedia integration language", new string[] { ".smil" }, new string[] { "application/smil" }, new string[] { "com.real.smil" }),
            new FileType("Stuffit archive", new string[] { ".sit", ".sitx" }, new string[] { "application/x-stuffit", "application/x-sit", "application/stuffit" }, new string[] { "com.allume.stuffit-archive" }),



            //UTType found by trying "random" files with the extension/type by calling mdls on mac terminal. MIME-type found different places online.
            new FileType("Markdown", new string[] { ".md", ".markdown", ".mdown", ".markdn", ".mkd" }, new string[] { "text/markdown" }, new string[] { "net.daringfireball.markdown" }),
            new FileType("Epub", new string[] { ".epub" }, new string[] { "application/epub+zip" }, new string[] { "org.idpf.epub-container" }),
            new FileType("MPEG-4 Apple m4v", new string[] { ".m4v" }, new string[] { "video/mp4" }, new string[] { "com.apple.m4v-video" }),
            new FileType("Matroska", new string[] { ".mkv", ".mka", ".mks" }, new string[] { "video/x-matroska", "audio/x-matroska" }, new string[] { "org.matroska.mkv" }),
            new FileType("SubRip", new string[] { ".srt" }, new string[] { "application/x-subrip" }, new string[] { "dyn.ah62d4rv4ge81g6xy" }),
            new FileType("JSON", new string[] { ".json" }, new string[] { "application/json" }, new string[] { "public.json" }),
            new FileType("Musical Instrument Digital Interface (MIDI)", new string[] { ".mid", ".midi" }, new string[] { "audio/midi", "audio/x-midi" }, new string[] { "public.midi-audio" }),
            new FileType("YAML", new string[] { ".yaml" }, new string[] { "application/yaml", "application/x-yaml", "text/yaml", "text/x-yaml", "application/openapi+yaml" }, new string[] { "public.yaml" }),
            new FileType("WebVTT", new string[] { ".vtt" }, new string[] { "text/vtt" }, new string[] { "org.w3.webvtt" })
        };

        /// <summary>
        /// List of UTI's that has children (the key), with it's children (the values). Can for example be used to find the tree of a type.
        /// </summary>
        public static readonly Dictionary<string, string[]> UTTypeParentsList = new Dictionary<string, string[]>
        {
            { "public.item",
                new string[]
                {
                    "public.data",
                    "public.directory",
                    "public.symlink",
                    "com.apple.mount-point"
                }
            },
            { "public.content",
                new string[]
                {
                    "public.composite-content",
                    "public.text",
                    "public.vcard",
                    "public.image",
                    "public.audiovisual-​content"
                }
            },
            { "public.composite-content",
                new string[]
                {
                    "public.presentation",
                    "com.apple.txn.text-​multimedia-data",
                    "com.apple.webarchive",
                    "com.apple.rtfd",
                    "com.apple.flat-rtfd",
                    "com.adobe.pdf",
                    "com.apple.keynote.kth"
                }
            },
            { "public.data",
                new string[]
                {
                    "public.text",
                    "public.vcard",
                    "public.image",
                    "public.audiovisual-​content",
                    "com.apple.ink.inktext",
                    "com.apple.applescript.​script",
                    "public.object-code",
                    "com.apple.mach-o-binary",
                    "com.apple.pef-binary",
                    "com.microsoft.windows-​executable",
                    "com.microsoft.windows-​dynamic-link-library",
                    "com.sun.java-class",
                    "com.sun.java-archive",
                    "com.apple.quartz-​composer-composition",
                    "org.gnu.gnu-tar-archive",
                    "org.gnu.gnu-zip-archive",
                    "com.apple.binhex-archive",
                    "com.apple.macbinary-​archive",
                    "public.url",
                    "com.apple.txn.text-​multimedia-data",
                    "com.apple.application-file",
                    "public.cpio-archive",
                    "com.pkware.zip-archive",
                    "com.apple.webarchive",
                    "com.apple.flat-rtfd",
                    "com.apple.alias-record",
                    "com.apple.alias-file",
                    "public.font",
                    "com.apple.colorsync-profile",
                    "com.adobe.pdf",
                    "com.adobe.postscript",
                    "com.microsoft.word.doc",
                    "com.microsoft.excel.xls",
                    "com.microsoft.powerpoint.​ppt",
                    "com.allume.stuffit-archive",
                    "dyn.ah62d4rv4ge81g6xy"
                }
            },
            { "public.presentation",
                new string[]
                {
                    "com.microsoft.powerpoint.​ppt",
                    "com.apple.keynote.key"
                }
            },
            { "public.archive",
                new string[]
                {
                    "public.disk-image",
                    "com.sun.java-archive",
                    "org.gnu.gnu-tar-archive",
                    "org.gnu.gnu-zip-archive",
                    "com.apple.binhex-archive",
                    "com.apple.macbinary-​archive",
                    "com.pkware.zip-archive",
                    "com.allume.stuffit-archive"
                }
            },
            { "public.text",
                new string[]
                {
                    "public.plain-text",
                    "public.rtf",
                    "public.html",
                    "public.xml",
                    "com.apple.ostype",
                    "com.apple.nspboard-type",
                    "public.json",
                    "public.yaml",
                    "org.w3.webvtt"
                }
            },
            { "public.plain-text",
                new string[]
                {
                    "public.utf8-plain-text",
                    "public.utf16-external-plain-​text",
                    "public.utf16-plain-text",
                    "com.apple.traditional-mac-​plain-text",
                    "public.source-code",
                    "net.daringfireball.markdown"
                }
            },
            { "public.source-code",
                new string[]
                {
                    "public.c-source",
                    "public.objective-c-source",
                    "public.c-plus-plus-source",
                    "public.objective-c-plus-​plus-source",
                    "public.c-header",
                    "public.c-plus-plus-header",
                    "com.sun.java-source",
                    "public.script",
                    "public.assembly-source",
                    "com.apple.rez-source",
                    "public.mig-source",
                    "com.apple.symbol-export",
                    "com.netscape.javascript-​source"
                }
            },
            { "public.script",
                new string[]
                {
                    "public.shell-script",
                    "com.apple.applescript.text"
                }
            },
            { "public.shell-script",
                new string[]
                {
                    "public.csh-script",
                    "public.perl-script",
                    "public.python-script",
                    "public.ruby-script",
                    "public.php-script"
                }
            },
            { "public.xml",
                new string[]
                {
                    "com.sun.java-web-start",
                    "com.microsoft.advanced-​stream-redirector",
                    "com.real.smil"
                }
            },
            { "public.executable",
                new string[]
                {
                    "com.netscape.javascript-​source",
                    "public.object-code",
                    "com.apple.mach-o-binary",
                    "com.apple.pef-binary",
                    "com.microsoft.windows-​executable",
                    "com.microsoft.windows-​dynamic-link-library",
                    "com.sun.java-class",
                    "com.sun.java-archive",
                    "com.apple.quartz-​composer-composition",
                    "com.apple.application"
                }
            },
            { "org.gnu.gnu-tar-archive",
                new string[]
                {
                    "public.tar-archive"
                }
            },
            { "org.gnu.gnu-zip-archve",
                new string[]
                {
                    "org.gnu.gnu-zip-tar-archive"
                }
            },
            { "public.image",
                new string[]
                {
                    "public.fax",
                    "public.jpeg",
                    "public.jpeg-2000",
                    "public.tiff",
                    "public.camera-raw-image",
                    "com.apple.pict",
                    "com.apple.macpaint-image",
                    "public.png",
                    "public.xbitmap-image",
                    "com.apple.quicktime-image",
                    "com.apple.icns",
                    "com.adobe.photoshop-​image",
                    "com.adobe.illustrator.ai-​image",
                    "com.compuserve.gif",
                    "com.microsoft.bmp",
                    "com.microsoft.ico",
                    "com.truevision.tga-image",
                    "com.sgi.sgi-image",
                    "com.ilm.openexr-image",
                    "com.kodak.flashpix.image"
                }
            },
            { "public.audiovisual-​content",
                new string[]
                {
                    "public.movie",
                    "public.audio",
                    "com.microsoft.advanced-​systems-format",
                    "com.microsoft.advanced-​stream-redirector"
                }
            },
            { "public.movie",
                new string[]
                {
                    "public.video",
                    "com.apple.quicktime-movie",
                    "public.avi",
                    "public.mpeg",
                    "public.mpeg-4",
                    "public.3gpp",
                    "public.3gpp2",
                    "com.microsoft.windows-​media-wm",
                    "com.microsoft.windows-​media-wmv",
                    "com.microsoft.windows-​media-wmp",
                    "com.real.realmedia",
                    "org.matroska.mkv"
                }
            },
            { "public.audio",
                new string[]
                {
                    "public.mp3",
                    "public.mpeg-4-audio",
                    "com.apple.protected-​mpeg-4-audio",
                    "public.ulaw-audio",
                    "public.aifc-audio",
                    "public.aiff-audio",
                    "com.apple.coreaudio-​format",
                    "com.microsoft.waveform-​audio",
                    "com.microsoft.windows-​media-wma",
                    "com.microsoft.windows-​media-wmx",
                    "com.microsoft.windows-​media-wvx",
                    "com.microsoft.windows-​media-wax",
                    "com.digidesign.sd2-audio",
                    "com.real.realaudio",
                    "public.midi-audio"
                }
            },
            { "public.mpeg-4",
                new string[]
                {
                    "public.mpeg-4-audio",
                    "com.apple.m4v-video"
                }
            },
            { "public.directory",
                new string[]
                {
                    "public.folder",
                    "com.apple.package",
                    "com.apple.bundle"
                }
            },
            { "public.folder",
                new string[]
                {
                    "public.volume"
                }
            },
            { "com.apple.package",
                new string[]
                {
                    "com.apple.application-​bundle",
                    "com.apple.plugin",
                    "com.apple.dashboard-​widget",
                    "com.apple.rtfd",
                    "com.apple.keynote.key",
                    "com.apple.keynote.kth"
                }
            },
            { "com.apple.bundle",
                new string[]
                {
                    "com.apple.application-​bundle",
                    "com.apple.plugin",
                    "com.apple.dashboard-​widget",
                    "com.apple.framework"
                }
            },
            { "com.apple.application",
                new string[]
                {
                    "com.apple.application-​bundle",
                    "com.apple.application-file",
                    "com.apple.deprecated-​application-file"
                }
            },
            { "com.apple.plugin",
                new string[]
                {
                    "com.apple.metadata-​importer"
                }
            },
            { "com.apple.resolvable",
                new string[]
                {
                    "public.symlink",
                    "com.apple.mount-point",
                    "com.apple.alias-record",
                    "com.apple.alias-file"
                }
            },
            { "public.font",
                new string[]
                {
                    "public.truetype-font",
                    "com.adobe.postscript-font",
                    "public.opentype-font",
                    "public.truetype-collection-​font",
                    "com.apple.font-suitcase"
                }
            },
            { "public.truetype-font",
                new string[]
                {
                    "com.apple.truetype-​datafork-suitcase-font",
                    "public.truetype-ttf-font"
                }
            },
            { "com.adobe.postscript-​font",
                new string[]
                {
                    "com.adobe.postscript-lwfn​-font",
                    "com.adobe.postscript-pfb-​font",
                    "com.adobe.postscript.pfa-​font"
                }
            },
            { "public.case-insensitive-text",
                new string[]
                {
                    "public.filename-extension",
                    "public.mime-type"
                }
            },
            { "com.adobe.postscript",
                new string[]
                {
                    "com.adobe.encapsulated-​postscript"
                }
            },
            { "com.microsoft.advanced-​systems-format",
                new string[]
                {
                    "com.microsoft.windows-​media-wmt",
                    "com.microsoft.windows-​media-wmv",
                    "com.microsoft.windows-​media-wmp",
                    "com.microsoft.windows-​media-wma"
                }
            },
            { "com.microsoft.advanced-​stream-redirector",
                new string[]
                {
                    "com.microsoft.windows-​media-wmxt",
                    "com.microsoft.windows-​media-wvx",
                    "com.microsoft.windows-​media-wax"
                }
            },
            { "public.fax",
                new string[]
                {
                    "com.j2.jfx-fax",
                    "com.js.efx-fax"
                }
            }
        };

        /// <summary>
        /// Goes through the given list of file types, and returns all types that has at least one of the given extension as one of it's given extensions.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="extensions">The file extensions to check. Each extension should have a leading dot.</param>
        /// <returns></returns>
        public static List<FileType> GetByExtension(this IEnumerable<FileType> fileTypes, IEnumerable<string> extensions)
        {
            var result = new List<FileType>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                if (fileType.HasExtension(extensions))
                {
                    result.Add(fileType);
                }

            }
            return result;
        }

        /// <summary>
        /// Goes through the given list of file types, and returns all types that has the given extension as one of it's given extensions.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="extension">The file extension to check. This should have a leading dot.</param>
        /// <returns></returns>
        public static List<FileType> GetByExtension(this IEnumerable<FileType> fileTypes, string extension)
        {
            var result = new List<FileType>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                if (fileType.HasExtension(extension))
                {
                    result.Add(fileType);
                }
            }
            return result;
        }

        /// <summary>
        /// Goes through the given list of file types, and returns all types that has at least one of the given mime-types as one of it's given mime-types.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="mimeTypes">The mime-types to check.</param>
        /// <returns></returns>
        public static List<FileType> GetByMimeType(this IEnumerable<FileType> fileTypes, IEnumerable<string> mimeTypes)
        {
            var result = new List<FileType>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                if (fileType.HasMimeType(mimeTypes))
                {
                    result.Add(fileType);
                }

            }
            return result;
        }

        /// <summary>
        /// Goes through the given list of file types, and returns all types that has the given mime-type as one of it's given mime-types.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="mimeType">The mime-type to check.</param>
        /// <returns></returns>
        public static List<FileType> GetByMimeType(this IEnumerable<FileType> fileTypes, string mimeType)
        {
            var result = new List<FileType>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                if (fileType.HasMimeType(mimeType))
                {
                    result.Add(fileType);
                }
            }
            return result;
        }

        /// <summary>
        /// Goes through the given list of file types, and returns all types that has at least one of the given UTTypes (UTI's) as one of it's given UTTypes.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="uTType">The UTTypes (UTI's) to check.</param>
        /// <returns></returns>
        public static List<FileType> GetByUTType(this IEnumerable<FileType> fileTypes, IEnumerable<string> uTType)
        {
            var result = new List<FileType>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                if (fileType.HasUTType(uTType))
                {
                    result.Add(fileType);
                }

            }
            return result;
        }

        /// <summary>
        /// Goes through the given list of file types, and returns all types that has the given UTType as one of it's given UTTypes.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="uTType">The UTType (UTI) to check.</param>
        /// <returns></returns>
        public static List<FileType> GetByUTType(this IEnumerable<FileType> fileTypes, string uTType)
        {
            var result = new List<FileType>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                if (fileType.HasUTType(uTType))
                {
                    result.Add(fileType);
                }
            }
            return result;
        }

        /// <summary>
        /// Get a list of UTTypes which are defined as it's children (and it's grandchildren, etc).
        /// </summary>
        /// <param name="listOfParents">The list of parents.</param>
        /// <param name="parent">The UTType that is the parent to get it's children and it's grandchildren.</param>
        /// <param name="includeParentAsItem">Should the given parent be part of the list that is returned.</param>
        /// <returns></returns>
        public static List<string> GetUTTypeChildrenByParent(this Dictionary<string, string[]> listOfParents, string parent, bool includeParentAsItem = true)
        {
            var result = new List<string>();
            if (includeParentAsItem)
            {
                result.Add(parent);
            }

            if (listOfParents != null && listOfParents.ContainsKey(parent))
            {
                foreach(var child in listOfParents[parent])
                {
                    result.AddRange(listOfParents.GetUTTypeChildrenByParent(child, true));
                }
            }

            return result;
        }

        /// <summary>
        /// Gets a one dimensional list of all the extensions in the list.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="removeDuplicates">If true, removes evt. duplicates, so it will not be shown.</param>
        /// <returns></returns>
        public static List<string> AllExtensions(this IEnumerable<FileType> fileTypes, bool removeDuplicates = true)
        {
            var result = new List<string>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                result.AddRange(fileType.Extensions);
            }

            if (removeDuplicates)
            {
                return result.Distinct().ToList();
            }
            return result;
        }

        /// <summary>
        /// Gets a one dimensional list of all the mime-types in the list.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="removeDuplicates">If true, removes evt. duplicates, so it will not be shown.</param>
        /// <returns></returns>
        public static List<string> AllMimeTypes(this IEnumerable<FileType> fileTypes, bool removeDuplicates = true)
        {
            var result = new List<string>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                result.AddRange(fileType.MimeTypes);
            }

            if (removeDuplicates)
            {
                return result.Distinct().ToList();
            }
            return result;
        }

        /// <summary>
        /// Gets a one dimensional list of all the mime-types in the list.
        /// </summary>
        /// <param name="fileTypes">The list of file types.</param>
        /// <param name="removeDuplicates">If true, removes evt. duplicates, so it will not be shown.</param>
        /// <returns></returns>
        public static List<string> AllUTTypes(this IEnumerable<FileType> fileTypes, bool removeDuplicates = true)
        {
            var result = new List<string>();
            if (fileTypes == null)
            {
                return result;
            }
            foreach (var fileType in fileTypes)
            {
                result.AddRange(fileType.UTTypes);
            }

            if (removeDuplicates)
            {
                return result.Distinct().ToList();
            }
            return result;
        }
    }
}

