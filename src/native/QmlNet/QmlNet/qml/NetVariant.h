#ifndef NETVARIANT_H
#define NETVARIANT_H

#include <QmlNet/types/NetReference.h>
#include <QVariant>
#include <QDateTime>

class NetVariant
{
public:
    NetVariant();
    ~NetVariant();
    NetVariantTypeEnum getVariantType();
    void setNetReference(QSharedPointer<NetReference> netReference);
    QSharedPointer<NetReference> getNetReference();
    void setBool(bool value);
    bool getBool();
    void setChar(QChar value);
    QChar getChar();
    void setInt(int value);
    int getInt();
    void setUInt(unsigned int value);
    unsigned int getUInt();
    void setDouble(double value);
    double getDouble();
    void setString(QString* value);
    QString getString();
    void setDateTime(QDateTime& value);
    QDateTime getDateTime();
    void clear();

    QVariant asQVariant();
private:
    void clearNetReference();
    QVariant variant;
};

struct NetVariantContainer {
    QSharedPointer<NetVariant> variant;
};

#endif // NETVARIANT_H
