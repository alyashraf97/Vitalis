using MudBlazor;

namespace Vitalis.Shared.Services
{
    public class ThemeService
    {
        public MudTheme CurrentTheme { get; private set; }

        public bool IsDarkMode { get; private set; }


        public event Action? ThemeChanged;
        private MudTheme _lightTheme;
        private MudTheme _darkTheme;

        public ThemeService()
        {
            // Define the light theme
            _lightTheme = new MudTheme()
            {
                Palette = new PaletteLight()
                /*
                {
                    Primary = "#1976d2",
                    Secondary = "#ff4081",
                    Background = "#f5f5f5",
                    AppbarBackground = "#ffffff",
                    DrawerBackground = "#f5f5f5",
                    DrawerText = "rgba(0,0,0, 0.87)",
                    TextPrimary = "rgba(0,0,0, 0.87)",
                    TextSecondary = "rgba(0,0,0, 0.54)"
                }
                */
            };

            // Define the dark theme
            _darkTheme = new MudTheme()
            {
                Palette = new PaletteDark()
                /*{
                    Primary = Colors.Blue.Lighten3,
                    Secondary = Colors.DeepPurple.Accent2,
                    Background = Colors.Grey.Darken4,
                    AppbarBackground = Colors.Grey.Darken3,
                    DrawerBackground = Colors.Grey.Darken4,
                    DrawerText = "rgba(255,255,255, 0.87)",
                    TextPrimary = "rgba(255,255,255, 0.87)",
                    TextSecondary = "rgba(255,255,255, 0.54)"
                }
                */
            };

            // Set the initial theme
            IsDarkMode = false;
            CurrentTheme = _lightTheme;
        }


        public void ToggleDarkMode()
        {
            IsDarkMode = !IsDarkMode;
            CurrentTheme = IsDarkMode ? _darkTheme : _lightTheme;
            ThemeChanged?.Invoke();
        }
    }
}
