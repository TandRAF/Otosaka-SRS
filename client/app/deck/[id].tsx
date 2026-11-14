import { View, Text } from "react-native";
import { useLocalSearchParams } from "expo-router";
import { mockDecks } from "../../utils/mockDecks";
import { TagsContainer } from "@/features/tag/components/TagsContainer";

export default function DeckScreen() {
  const { id } = useLocalSearchParams<{ id: string }>();
  const deck = mockDecks.find((d) => d.id === id);
  const tags = deck?.tags ?? []


  if (!deck) {
    return (
      <View className="flex-1 items-center justify-center bg-bg">
        <Text className="text-white">Deck not found</Text>
      </View>
    );
  }

  return (
    <View className="flex-1 p-10 bg-bg pt-16 px-4 gap-3">
      <Text className="color-text font-bold text-lg">{deck.name}</Text>
      <TagsContainer tags={tags}/>
    </View>
  );
}