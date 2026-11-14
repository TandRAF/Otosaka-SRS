import "../global.css";
import { View } from "react-native";
import { Stack, usePathname } from "expo-router";
import BottomNav from "@/layouts/BottomNav";

export default function RootLayout() {
  const pathname = usePathname();
  const hideNav = pathname.startsWith("/deck");

  return (
    <View className="flex-1 bg-[#111111]">
      <Stack
        screenOptions={{
          headerShown: false,
          contentStyle: { backgroundColor: "#111111" },
        }}
      >
        <Stack.Screen name="index" />
        <Stack.Screen name="profile" />
        <Stack.Screen name="deck/[id]" />
      </Stack>

      {!hideNav && (
        <View className="absolute bottom-0 left-0 right-0">
          <BottomNav />
        </View>
      )}
    </View>
  );
}