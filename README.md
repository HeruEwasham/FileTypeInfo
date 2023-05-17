# FileTypeInfo

A collection of FileTypes with both file extensions, mime-types and UTType (UTI (Universal Type Identifier)). The FileType-structure makes it also easy to create other types not defined yet also.

## Why this was made

This was made because I needed a way to easily get both extensions, mime-types and UTType (also called UTI (Universal Type Identifier)) of a given type/extension in a MAUI-application. I tried to find a library that could do this, but could only find extension and mime-type-mappings, and not anything with UTType/UTI.

## Features

- Has a list of FileTypes already defined. This contains most of the file-types defined in https://developer.apple.com/library/archive/documentation/Miscellaneous/Reference/UTIRef/Articles/System-DeclaredUniformTypeIdentifiers.html, plus some more.
- Has some extension-methods to get FileTypes based on extensions, mime-types and UTTypes for an IEnumerable of FileType.
- Has a predefined Dictionary of UTTypes childs.
- Some extension-methods to, by a given UTType, get it's children. This can then for example be used to again get a collection of file types (like getting all file types defined as children to the "public.image" UTI).
- Use the Filetype-class to create your own types. Either in conjunction with some or all of the alredy defined types, or alone.

## Some things to watch out for

- Mark that while the most mime-types is properly defined, a few of the mime-types defined can be very broad, or not defined on some rare types. This is because either no mime type was found for the type, or only a broad one was found. If you know a better mime-type, I will be glad if you want to contribute.
- Mark that while some of the UTType-parents maybe only contains the expected types, many, like "public.image", also contains some rare or maybe not expected types. Therefore, I will reccommend that if you use UTType-parents to get a collection of FileType's, you don't use it directly on the whole defined list of FileType's, but only use it on a subset of the list, so you know what you are getting.

## Contribute

If you want to contribute, either it is fixing some bugs, adding one or more types to the list, or new features, you are welcome to both create a PR or create an issue.

### How to add a new type to the list

You need first to find the file extension(s), mime-type(s) and at least one UTType/UTI (and hopefully also the parent(s) (what Apple calls "conforms to"), so it can be added to its parent(s) (but not it grandparents). See below for how you can find these. If you don't have the possibillity to find the UTType/UTI (like don't have a MAC), but want to contribute, create an issue with all the other information. A properly created example-file would also be appriciated in such a case.

#### Find the mime-type

There are multiple ways to do this. Online it is databases with many extensions and their types. Sadly, theese don't have all, as I found out when creating this list. It also exists some online file-checkers.

If you have a file and are on a linux-computer (at least ubuntu), you can use what it says here (not tested): https://askubuntu.com/questions/3395/how-to-get-the-mime-type-of-a-file-from-the-command-line

If you have a file and are on mac, you can use the method described here: https://stackoverflow.com/questions/46217787/where-is-the-location-of-the-mime-plugin-files-in-mac-and-linux

#### Find the UTType/UTI

The UTType/UTI is something Apple has defined themself (see more info about it here https://en.wikipedia.org/wiki/Uniform_Type_Identifier, and maybe also some here https://developer.apple.com/documentation/uniformtypeidentifiers).

To find the type, you can see https://superuser.com/questions/209145/how-to-get-a-files-uti-from-the-command-line-in-mac-os-x. If you call `mdls "FILENAME"`, where FILENAME is the path to the file, you will also get many other entries. One of them is "kMDItemContentTypeTree", which will help find which parents it has. The first entry is usually it's own UTI, and then parents and grandparents come in a single list.