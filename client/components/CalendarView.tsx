import { View, Text } from "react-native";

const days = Array.from({ length: 30 }, (_, i) => i + 1);

export default function CalendarView() {
  return (
    <View className="bg-white rounded-2xl p-4">
      <Text className="text-lg font-semibold mb-3">November 2026</Text>
      <View className="flex-row flex-wrap">
        {days.map((day) => (
          <View key={day} className="w-[14.28%] items-center py-2">
            <Text className="text-gray-700">{day}</Text>
          </View>
        ))}
      </View>
    </View>
  );
}