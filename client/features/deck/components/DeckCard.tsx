import { TagsContainer } from "@/features/tag/components/TagsContainer";
import { View, Text, Pressable } from "react-native";

type Props = {
  name: string;
  examDate?: string;
  tags?: string[];
  cardCount: number;
  onPress?: () => void;
};

export default function DeckCard({ name, examDate, tags = [], cardCount, onPress }: Props) {
  return (
    <Pressable
      onPress={onPress}
      className="bg-deck rounded-[32px] p-6 active:opacity-90"
    >
      {examDate && (
        <Text className="text-text text-base mb-3">
          Examen on <Text className="font-bold">{examDate}</Text>
        </Text>
      )}

      <Text className="text-text text-4xl font-bold leading-[42px] mb-4">
        {name}
      </Text>

     <TagsContainer tags={tags}/>
    </Pressable>
  );
}