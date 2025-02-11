from math import pi

# Base class
class Shape:
    def area(self):
        raise NotImplementedError("Subclass must implement abstract method")

# Derived class 1
class Circle(Shape):
    def __init__(self, radius):
        self.radius = radius

    def area(self):
        return pi * self.radius ** 2

# Derived class 2
class Rectangle(Shape):
    def __init__(self, width, height):
        self.width = width
        self.height = height

    def area(self):
        return self.width * self.height

# Function that accepts a Shape (Base Class) object
def print_area(shape):
    print(f"Area: {shape.area()}")

# Creating objects of derived classes
circle = Circle(5)
rectangle = Rectangle(4, 6)

# Substitutability: Treating derived class objects as base class objects
shapes = [circle, rectangle]  # List of Shape objects

# Iterating over shapes and calculating their area
for shape in shapes:
    print_area(shape)
