## This is the dependency base. 

### How modules work

Most modules are entirely web-based. So, in order to make development easy I used the Cef (Chromium Embedded framework) and developed a webview system. 
Modules are usually two files, and one folder. The first file being `meta.json'.` This file contains all Meta data that Cobalt can read and then display on screen for the user to see. The `modulename.ini` file contains all the module information for the webview to load. Such as how large the window needs to be, it's color, url, and other important option. It's usually meant to be left alone, so that you don't break your modules. Last but not least, there is the icons folder. This folder can contain any needed module icons; this information is actually stored within `meta.json` and can be parsed at any given time. The `.ini` module file can also contain this information for additional icons; if wanted. 


### How to make modules easily

Cobalt will include a module wrapper tool in order to actually make modules and deploy them easily. That and it will create both the module `ini` and `json` with the 
required dependencies that you can list when making a module. That, and you can preview your module in action (in real time.)