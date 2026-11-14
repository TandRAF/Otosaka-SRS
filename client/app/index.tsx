import { ScrollView, Text, Pressable, View } from "react-native";
import { Link, router } from "expo-router";
import StatsWidget from "../components/StatsWidget";
import CalendarView from "../components/CalendarView";
import { mockDecks } from "../utils/mockDecks";
import { useState } from "react";
import WeekCalendar from "@/components/WeekCalendar";
import DeckCard from "@/features/deck/components/DeckCard";

export default function HomeScreen() {
  const [selectedDate, setSelectedDate] = useState(new Date());
  const dueToday = mockDecks
    .flatMap((d) => d.cards)
    .filter((c) => c.status === "due").length;

  return (
    <ScrollView className="flex-1 pt-24 bg-bg" contentContainerClassName="p-4 gap-4">
      <View className="flex flex-col gap-1">
        <Text className="color-text text-md font-semibold">Good Morning, The Hermit</Text>
        <Text className="color-text text-sm">i see u have a hard exam in 20 days</Text>
      </View>
      <WeekCalendar selected={selectedDate} onSelect={setSelectedDate} />
      <Text className="color-text text-sm mt-2">Your decks</Text>
      {mockDecks.map((deck,index) => (
        <DeckCard
          key={index}
          name={deck.name}
          examDate={deck.examDate}
          tags={deck.tags}
          cardCount={deck.cardCount ?? deck.cards.length}
          onPress={() => router.push(`/deck/${deck.id}`)}
        />
      ))}
    </ScrollView>
  );
}