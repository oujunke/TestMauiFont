// See https://aka.ms/new-console-template for more information
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Skia;
using SkiaSharp;

var fontPath = "BRITANIC.TTF";
Font font = new Font(fontPath);
var typeface=font.ToSKTypeface();
var skTypeface=SKTypeface.FromFile(fontPath);
Console.WriteLine(typeface.FamilyName);
Console.WriteLine(skTypeface.FamilyName);
Console.ReadLine();

