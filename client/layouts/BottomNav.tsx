import { View, Pressable } from "react-native";
import { LinearGradient } from "expo-linear-gradient";
import { useRouter, usePathname } from "expo-router";
import { useSafeAreaInsets } from "react-native-safe-area-context";
import Icon from "@/components/Icon";

export default function BottomNav() {
  const router = useRouter();
  const pathname = usePathname();
  const insets = useSafeAreaInsets();

  const onHome = pathname === "/";
  const onProfile = pathname === "/profile";

  return (
    <LinearGradient
      colors={["rgba(17,17,17,0)", "rgba(17,17,17,0.9)", "#111111"]}
      locations={[0, 0.5, 1]}
      className="absolute bottom-0 left-0 right-0"
    >
      <View
        className="flex-row justify-between items-center px-6 pt-4"
        style={{ paddingBottom: insets.bottom + 12 }}
      >
        <Pressable
          onPress={() => {
            // TODO: open add-deck screen
          }}
          className="w-16 h-16 rounded-full bg-white items-center justify-center active:opacity-80"
        >
          <Icon name="create" />
        </Pressable>

        <View className="flex-row items-center bg-black rounded-full p-1.5">
          <Pressable
            onPress={() => router.navigate("/profile")}
            className="px-5 py-3 items-center justify-center"
          >
            <Icon name="profile" />
          </Pressable>

          <Pressable
            onPress={() => router.navigate("/")}
            className={`w-16 h-16 rounded-full items-center justify-center ${
              onHome ? "bg-white" : ""
            }`}
          >
            <Icon name="decks" />
          </Pressable>
        </View>
      </View>
    </LinearGradient>
  );
}