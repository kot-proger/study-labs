from django.db import models

# Create your models here.

class AccessoryModel(models.Model):

    type_choice = [
        (1, "tuner"),
        (2, 'mediator'),
        (3, 'wire'),
        (4, 'belt')
    ]

    type = models.IntegerField(choices=type_choice, default= 1)
    name = models.CharField(max_length=40, default="")
    manufacturer = models.CharField(max_length=50, default="")
    cost = models.FloatField(max_length=10, default=1)

    def __str__(self):
        return self.name

class GuitarTypeModel(models.Model):

    type_choice = [
        (1, "electric"),
        (2, "acoustic"),
        (3, "bass")
    ]

    name = models.IntegerField(choices=type_choice, default=1)

    def __str__(self):
        return self.name

class ComboAmpsModel(models.Model):

    name = models.CharField(max_length=40, default="")
    power = models.IntegerField(max_length=3, default=10)
    guitar_type = models.ForeignKey(GuitarTypeModel, on_delete=models.CASCADE)
    cost = models.FloatField(max_length=10, default=1)

    def __str__(self):
        return self.name

class EffectsModel(models.Model):

    effect_choice = [
        (1, "processor"),
        (2, "compressor"),
        (3, "wah-wah"),
        (4, "distortion"),
        (5, "phaser"),
        (6, "delay"),
        (7, "reverb")
    ]

    name = models.CharField(max_length=40, default="")
    effect = models.IntegerField(choices=effect_choice, default=1)
    cost = models.FloatField(max_length=10, default=1)

    def __str__(self):
        return self.name

class GuitarsModel(models.Model):

    name = models.CharField(max_length=255, default="")
    type = models.ForeignKey(GuitarTypeModel, on_delete=models.CASCADE)
    number_of_strings = models.IntegerField(max_length=2, default=6)
    cost = models.FloatField(max_length=10, default=1)

    def __str__(self):
        return self.name

class StringsModel(models.Model):

    name = models.CharField(max_length=255, default="")
    number_of_strings = models.IntegerField(max_length=2, default=6)
    caliber = models.IntegerField(max_length=3, default=8)
    guitar_type = models.ForeignKey(GuitarTypeModel, on_delete=models.CASCADE)
    cost = models.FloatField(max_length=10, default=1)

    def __str__(self):
        return self.name