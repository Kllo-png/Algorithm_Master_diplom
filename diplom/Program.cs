using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class FontManager
{
    private static readonly PrivateFontCollection privateFontCollection = new PrivateFontCollection();
    private static readonly List<IntPtr> fontMemory = new List<IntPtr>();

    static FontManager()
    {
        LoadFontFromResource("Montserrat-Medium.ttf");
    }

    public static void LoadFontFromResource(string resourceName)
    {
        try
        {
            var assembly = Assembly.GetExecutingAssembly();
            string? manifestResourceName = assembly
                .GetManifestResourceNames()
                .FirstOrDefault(name => name.EndsWith(resourceName, StringComparison.OrdinalIgnoreCase));

            if (manifestResourceName == null)
                throw new FileNotFoundException($"Resource {resourceName} not found");

            using (Stream? fontStream = assembly.GetManifestResourceStream(manifestResourceName))
            {
                if (fontStream == null)
                    throw new FileNotFoundException($"Resource {manifestResourceName} not found");

                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, (int)fontStream.Length);

                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
                privateFontCollection.AddMemoryFont(fontPtr, fontData.Length);
                fontMemory.Add(fontPtr);
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error loading font: {ex.Message}");
        }
    }

    public static void Initialize()
    {
        _ = privateFontCollection.Families.Length;
    }

    public static Font GetFont(string fontFamily, float size, FontStyle style = FontStyle.Regular)
    {
        try
        {
            if (privateFontCollection.Families.Length > 0)
            {
                var fontFamilyName = privateFontCollection.Families[0].Name;
                return new Font(fontFamilyName, size, style);
            }
        }
        catch
        {
            System.Diagnostics.Debug.WriteLine("Custom font not available, using fallback");
        }

        return new Font(fontFamily, size, style);
    }

    public static void ApplyTo(Control parent)
    {
        ApplyFont(parent);

        foreach (Control child in parent.Controls)
        {
            ApplyTo(child);
        }
    }

    private static void ApplyFont(Control control)
    {
        if (control.Font == null)
            return;

        Font currentFont = control.Font;
        control.Font = GetFont(currentFont.FontFamily.Name, currentFont.Size, currentFont.Style);
    }
}

namespace diplom
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            FontManager.Initialize();

            Application.Run(new Form1());
        }
    }
}
