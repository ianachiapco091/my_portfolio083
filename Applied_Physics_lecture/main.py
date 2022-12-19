# -*- coding: utf-8 -*-
"""
Created on Sun Dec 18 15:32:24 2022

@author: Tatiana Chiapco
"""

from convert import Conversion_Calc_Meter

print("Unit Conversion Calculator: Meters")

while True:
    
    print("*** Units Available for Unit Conversion ***")
    print("""
          - Decimeter     - Decameter    - Gigameter
          - Centimeter    - Hectometer
          - Millimeter    - Meter
          - Micrometer    - Kilometer
          - Nanometer     - Megameter               """)
    
    current_unit = input("Choose the current unit: ")
    print("Current Unit: " + current_unit)
    value = input("Enter the number for value: ")
    convert_unit = input("Convert to: ").lower()
    
    if convert_unit == "decameter":
        value_2 = Conversion_Calc_Meter.convert_to_decameter(current_unit, value)
        print(str(value_2) + " dem")
    elif convert_unit == "hectometer":
        value_2 = Conversion_Calc_Meter.convert_to_hectometer(current_unit, value)
        print(str(value_2) + " hm")
    elif convert_unit == "meter":
        value_2 = Conversion_Calc_Meter.convert_to_meter(current_unit, value)
        print(str(value_2) + " m")
    elif convert_unit == "kilometer":
        value_2 = Conversion_Calc_Meter.convert_to_kilometer(current_unit, value)
        print(str(value_2) + " km")
    elif convert_unit == "megameter":
        value_2 = Conversion_Calc_Meter.convert_to_megameter(current_unit, value)
        print(str(value_2) + " Mm")
    elif convert_unit == "gigameter":
        value_2 = Conversion_Calc_Meter.convert_to_gigameter(current_unit, value)
        print(str(value_2) + " Gm")
    elif convert_unit == "decimeter":
        value_2 = Conversion_Calc_Meter.convert_to_decimeter(current_unit, value)
        print(str(value_2) + " dm")
    elif convert_unit == "centimeter":
        value_2 = Conversion_Calc_Meter.convert_to_centimeter(current_unit, value)
        print(str(value_2) + " cm")
    elif convert_unit == "millimeter":
        value_2 = Conversion_Calc_Meter.convert_to_millimeter(current_unit, value)
        print(str(value_2) + " mm")
    elif convert_unit == "micrometer":
        value_2 = Conversion_Calc_Meter.convert_to_micrometer(current_unit, value)
        print(str(value_2) + " um")
    elif convert_unit == "nanometer":
        value_2 = Conversion_Calc_Meter.convert_to_nanometer(current_unit, value)
        print(str(value_2) + " nm")
    
    print("Try again? [Y] or [N]")
    respons = input(">>>> ").upper()
    
    if respons == "Y":
        continue
    else:
        break