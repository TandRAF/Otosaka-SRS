import { View, Text } from "react-native";

type Props = {
  dueToday: number;
  streak: number;
};

export default function StatsWidget({ dueToday, streak }: Props) {
  return (
    <View className="bg-indigo-500 rounded-2xl p-5 flex-row justify-between">
      <View>
        <Text className="text-white/80 text-sm">Due today</Text>
        <Text className="text-white text-3xl font-bold">{dueToday}</Text>
      </View>
      <View>
        <Text className="text-white/80 text-sm">Streak</Text>
        <Text className="text-white text-3xl font-bold">{streak} days</Text>
      </View>
    </View>
  );
}