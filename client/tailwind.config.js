/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./app/**/*.{js,jsx,ts,tsx}",
    "./components/**/*.{js,jsx,ts,tsx}",
    "./features/**/*.{js,jsx,ts,tsx}",
    "./layouts/**/*.{js,jsx,ts,tsx}"
  ],
  presets: [require("nativewind/preset")],
  theme: {
    extend: {
      colors: {
        primary: "#FF715B",
        bg:"#121212",
        text:"#F4F4F4",
        deck:"#1D1D1D",
        calendar: {
          card: "#1c1c1c",
          selected: "#ef7b62",
          muted: "#9a9a9a",
          ink: "#111111",
        },
      },
      fontSize: {
        sm: "14px",
        md: "24px",
        lg: "32px"
      }
  },
  plugins: [],
}
}