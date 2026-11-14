import CreateIcon from "../assets/icons/create.svg";
import ProfileIcon from "../assets/icons/profile.svg";
import DecksIcon from "../assets/icons/decks.svg";
const ICONS = {
  create: CreateIcon,
  profile: ProfileIcon,
  decks: DecksIcon,
} as const;

type IconName = keyof typeof ICONS;

type Props = {
  name: IconName;
  size?: number;
  color?: string;
};

export default function Icon({ name, size = 24, color = "#ffffff" }: Props) {
  const SvgIcon = ICONS[name];
  return <SvgIcon width={size} height={size} color={color} />;
}