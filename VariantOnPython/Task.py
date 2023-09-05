def Create_userArray():
    userarray = []
    user_count_element = int(input("Enter the count of elements: "))
    for i in range(user_count_element):
        user_element = input(f"Enter the element {i+1}: ")
        userarray.append(user_element)
    return userarray

# shortened solution
def FinalArray1(default_array):
    final_array = [value for value in default_array if len(value) <= 3]
    return final_array

# NOT an abbreviated solution
def FinalArray(default_array):
    finalrray = []
    for value in default_array:
        if len(value) <= 3:
            finalrray.append(value)
    return finalrray


defaultarray = Create_userArray()
print("Default array: ", defaultarray)

result = FinalArray(defaultarray)
print("Final array: ", result)