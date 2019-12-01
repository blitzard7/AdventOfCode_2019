defmodule Day01 do
  def calculate_fuel(mass) do
    divider = 3
    substractor = 2
    trunc((mass / divider)) - substractor
  end

  def read_data_from_file(path) do
    File.stream!(path)
    |> Enum.map(fn x -> Integer.parse(x) |> elem(0) end)
  end
end

data = Day01.read_data_from_file("../data/day01.txt")

# puzzle 1: 3233481
result = data
  |> Enum.map(fn x -> Day01.calculate_fuel(x) end)
  |> Enum.sum
