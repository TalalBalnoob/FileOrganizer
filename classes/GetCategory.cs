using System;

namespace FileOrganizer.classes;

public class Category
{
	public static string GetCategory(string extension)
	{
		return extension switch
		{
			".rpm" or ".deb" or ".exe" or ".appimage" or ".flatpakref" => "Apps",
			".jpg" or ".png" or ".gif" or ".svg" => "Images",
			".txt" or ".pdf" or ".docx" => "Docs",
			".zip" or ".gz" or ".tar" => "Zips",
			".mp3" or ".wav" => "Music",
			".mp4" or ".avi" => "Videos",
			".srt" => "Subtitles",
			_ => "NONE"
		};
	}
}
