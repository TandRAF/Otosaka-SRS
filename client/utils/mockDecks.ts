export type Card = {
  id: string;
  front: string;
  back: string;
  status: "new" | "due" | "hard" | "known";
};

export type Deck = {
  id: string;
  name: string;
  examDate?: string;
  tags?: string[];
  cardCount?: number;
  cards: Card[];
};

export const mockDecks: Deck[] = [
  {
    id: "1",
    name: "Spanish Basics",
    tags: ["A1", "Food", "Vocabulary"],
    cards: [
      { id: "a", front: "Hola", back: "Hello", status: "due" },
      { id: "b", front: "Gracias", back: "Thank you", status: "hard" },
      { id: "c", front: "Adiós", back: "Goodbye", status: "new" },
      { id: "d", front: "Perro", back: "Dog", status: "known" },
    ],
  },
  {
    id: "2",
    name: "React Native",
    tags: ["Expo", "Hooks"],
    cards: [
      { id: "e", front: "What is a hook?", back: "A function that lets you use state and lifecycle features", status: "due" },
      { id: "f", front: "What is Expo Router?", back: "File-based routing for Expo apps", status: "new" },
    ],
  },
  {
    id: "3",
    name: "German Language",
    examDate: "26.11.2026",
    tags: ["A1", "B1", "Food", "Work", "Illnesses", "Grammar", "Vocabulary", "A2", "Pronunciation"],
    cardCount: 162,
    cards: [],
  },
];