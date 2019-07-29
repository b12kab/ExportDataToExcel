# Export ListView Items to Excel File in Xamarin.Forms

### My article on exporting saving files
[Blog entry](https://keithbeattyblog.wordpress.com/)

### Original Repo

[Github](https://github.com/egbakou/ExportDataToExcel)

### Reason for fork

I wanted to experiment more with the allow and deny action, as the original example was pretty simplistic. Android changes:

* If user does not allow, then do not go into the export code logic. 
* Change export directory to Downloads directory

I also upgraded it to XF 4.1, Android 28

Note: This and other Excel or CSV exporters have this error: 
> Warning MSB3277: Found conflicts between different versions of "Microsoft.CSharp" that could not be resolved.  These reference conflicts are listed in the build log when log verbosity is set to detailed. (MSB3277)