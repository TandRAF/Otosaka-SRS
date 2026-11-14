import { View, Text, Pressable } from "react-native";
interface Props {
    tags:string[],
}

export const TagsContainer = ({tags}:Props) => {
  return (
    <View className="flex-row flex-wrap gap-1 flex-1 mr-4">
          {tags.map((tag,index) => (
             <View key={index} className="border-solid border-text border-[1px] rounded-full px-3 py-1.5">
                <Text className="text-white text-sm">{tag}</Text>
            </View>
          ))}
    </View>
  )
}
