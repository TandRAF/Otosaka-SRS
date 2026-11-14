import { useState } from "react";
import { View, Text, Pressable } from "react-native";

const DAY_LETTERS = ["S", "M", "T", "W", "T", "F", "S"];

function getWeekDays(anchor: Date): Date[] {
  const sunday = new Date(anchor);
  sunday.setHours(0, 0, 0, 0);
  sunday.setDate(anchor.getDate() - anchor.getDay());

  return Array.from({ length: 7 }, (_, i) => {
    const d = new Date(sunday);
    d.setDate(sunday.getDate() + i);
    return d;
  });
}

function isSameDay(a: Date, b: Date) {
  return (
    a.getFullYear() === b.getFullYear() &&
    a.getMonth() === b.getMonth() &&
    a.getDate() === b.getDate()
  );
}

type Props = {
  selected?: Date;
  onSelect?: (date: Date) => void;
};

export default function WeekCalendar({ selected, onSelect }: Props) {
  const [internal, setInternal] = useState<Date>(new Date());
  const current = selected ?? internal;
  const days = getWeekDays(current);

  const handlePress = (date: Date) => {
    setInternal(date);
    onSelect?.(date);
  };

  return (
    <View className="flex-row">
      {days.map((date) => {
        const isSelected = isSameDay(date, current);

        return (
          <Pressable
            key={date.toISOString()}
            onPress={() => handlePress(date)}
            className={`flex-1 mx-1 py-4 rounded-3xl items-center ${
              isSelected ? "bg-calendar-selected" : "bg-calendar-card"
            }`}
          >
            <Text
              className={`text-sm ${
                isSelected ? "text-calendar-ink" : "text-calendar-muted"
              }`}
            >
              {DAY_LETTERS[date.getDay()]}
            </Text>
            <Text
              className={`text-md font-bold mt-1.5 ${
                isSelected ? "text-calendar-ink" : "text-white"
              }`}
            >
              {date.getDate()}
            </Text>
          </Pressable>
        );
      })}
    </View>
  );
}